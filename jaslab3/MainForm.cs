using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace jaslab3
{
    public partial class MainForm : Form
    {
        public NpgsqlConnection Connection = null;
        private DataSet _dataSet;

        private NpgsqlDataAdapter _cabinDataAdapter;
        private NpgsqlDataAdapter _passengerDataAdapter;

        private ConnectionForm _connectionForm;
        private CabinForm _cabinForm;
        private PassengerForm _passengerForm;

        public MainForm()
        {
            InitializeComponent();
            
            _dataSet = new DataSet();
            _dataSet.Tables.Add("cabins");
            _dataSet.Tables.Add("passengers");

            _connectionForm = new ConnectionForm {Parent = this};
            _cabinForm = new CabinForm {Parent = this};
            _passengerForm = new PassengerForm {Parent = this};
        }

        public NpgsqlConnection Connect(string host, int port, string database, string user, string password)
        {
            NpgsqlConnectionStringBuilder stringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = host,
                Port = port,
                Username = user,
                Password = password,
                Database = database,
                Timeout = 30
            };

            var conn = new NpgsqlConnection(stringBuilder.ConnectionString);
            conn.Open();
            return conn;
        }
        
        public void AddCabin(string name, int square, string className)
        {
            _dataSet.Tables["cabins"].Rows.Add(0, name, square, className);
            _cabinDataAdapter.Update(_dataSet, "cabins");
        }
        
        public void UpdateCabin(int row, string name, int square, string className)
        {
            _dataSet.Tables["cabins"].Rows[row]["cabin_name"] = name;
            _dataSet.Tables["cabins"].Rows[row]["square"] = square;
            _dataSet.Tables["cabins"].Rows[row]["class_name"] = className;
            _cabinDataAdapter.Update(_dataSet, "cabins");
        }
        
        public void AddPassenger(string firstName, string secondName, string sex, int groupId)
        {
            _dataSet.Tables["passengers"].Rows.Add(0, firstName, secondName, sex, groupId);
            _passengerDataAdapter.Update(_dataSet, "passengers");
        }
        
        public void UpdatePassenger(int row, string firstName, string secondName, string sex)
        {
            _dataSet.Tables["passengers"].Rows[row]["first_name"] = firstName;
            _dataSet.Tables["passengers"].Rows[row]["last_name"] = secondName;
            _dataSet.Tables["passengers"].Rows[row]["sex"] = sex;
            _passengerDataAdapter.Update(_dataSet, "passengers");
        }
        
        public void FillCabinsGrid()
        {
            _dataSet.Tables["cabins"].Clear();
            _cabinDataAdapter = new NpgsqlDataAdapter("SELECT * FROM cabins", Connection);
            new NpgsqlCommandBuilder(_cabinDataAdapter);
            _cabinDataAdapter.Fill(_dataSet, "cabins");
            cabinGrid.DataSource = _dataSet.Tables["cabins"];
        }
        
        public void FillPassengersGrid(string cabinName)
        {
            _dataSet.Tables["passengers"].Clear();
            _passengerDataAdapter = new NpgsqlDataAdapter(
                "SELECT passengers.* " +
                "FROM cabins, passengers " +
                "WHERE cabins.cabin_id = passengers.cabin_id AND cabin_name = '" + cabinName + "'", Connection);
            new NpgsqlCommandBuilder(_passengerDataAdapter);
            _passengerDataAdapter.Fill(_dataSet, "passengers");
            passengerGrid.DataSource = _dataSet.Tables["passengers"];
        }

        private void OnConnectItemClick(object sender, EventArgs e)
        {
            _connectionForm.Visible = true;
        }

        private void OnDisconnectItemClick(object sender, EventArgs e)
        {
            Connection.Close();
        }

        private void OnContextCabinAddClick(object sender, EventArgs e)
        {
            _cabinForm.Visible = true;
            _cabinForm.Reset(false, "", "", "");
        }

        private void OnContextCabinRemoveClick(object sender, EventArgs e)
        {
            int selectedRow = cabinGrid.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Видалити каюту?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                _dataSet.Tables["cabins"].Rows[selectedRow].Delete();
                _cabinDataAdapter.Update(_dataSet, "cabins");
                _dataSet.Clear();
                FillCabinsGrid();
            }

        }

        private void OnContextCabinEditClick(object sender, EventArgs e)
        {
            _cabinForm.Visible = true;
            var selectedRow = cabinGrid.SelectedCells[0].RowIndex;
            var cabinName = (string) _dataSet.Tables["cabins"].Rows[selectedRow].ItemArray[1];
            var cabinSquare = (string) _dataSet.Tables["cabins"].Rows[selectedRow].ItemArray[2];
            var cabinClass = (string) _dataSet.Tables["cabins"].Rows[selectedRow].ItemArray[3];
            _cabinForm.Reset(true, cabinName, cabinSquare, cabinClass);
            _cabinForm.Row = selectedRow;
        }

        private void OnContextPassengerAddClick(object sender, EventArgs e)
        {
            _passengerForm.Visible = true;
            _passengerForm.Reset(false, "", "", "");

            var selectedRow = cabinGrid.SelectedCells[0].RowIndex;
            var cabinId = (int) _dataSet.Tables["cabins"].Rows[selectedRow].ItemArray[0];
            var cabinName = (string) _dataSet.Tables["cabins"].Rows[selectedRow].ItemArray[1];
            
            _passengerForm.CabinName = cabinName;
            _passengerForm.CabinId = cabinId;
        }

        private void OnContextPassengerRemoveClick(object sender, EventArgs e)
        {
            var selectedRow = passengerGrid.SelectedCells[0].RowIndex;
            var dr = MessageBox.Show("Видалити пасажира?", "", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes) return;
            
            _dataSet.Tables["passengers"].Rows[selectedRow].Delete();
            _passengerDataAdapter.Update(_dataSet, "passengers");
            var key = (string) cabinGrid.Rows[selectedRow].Cells[1].Value;
            
            FillPassengersGrid(key);
        }

        private void OnContextPassengerEditClick(object sender, EventArgs e)
        {
            int selectedRowPass = passengerGrid.SelectedCells[0].RowIndex;
            string firstName = (string) _dataSet.Tables["passengers"].Rows[selectedRowPass].ItemArray[1];
            string secondName = (string) _dataSet.Tables["passengers"].Rows[selectedRowPass].ItemArray[2];
            string sex = (string) _dataSet.Tables["passengers"].Rows[selectedRowPass].ItemArray[3];
            _passengerForm.Visible = true;
            _passengerForm.Reset(true, firstName, secondName, sex);
            _passengerForm.Row = selectedRowPass;
            
            int selectedRowCab = cabinGrid.SelectedCells[0].RowIndex;
            string cabinName = (string) _dataSet.Tables["cabins"].Rows[selectedRowCab].ItemArray[1];
            _passengerForm.CabinName = cabinName;

        }

        private void OnCabinCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var sel = cabinGrid.SelectedCells;
            if (sel.Count == 0)
                return;
            
            int selectedRow = sel[0].RowIndex;
            string key = (string) cabinGrid.Rows[selectedRow].Cells[1].Value;
            FillPassengersGrid(key);
        }
    }
}