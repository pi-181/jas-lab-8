using System;
using System.Windows.Forms;
using Npgsql;

namespace jaslab3
{
    public partial class ConnectionForm : Form
    {
        public MainForm Parent { get; set; }
        
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void OnConnectButtonClick(object sender, EventArgs e)
        {
            NpgsqlConnection connection = Parent.Connect(
                hostBox.Text, int.Parse(portBox.Text), databaseBox.Text, userBox.Text, passwordBox.Text
            );
            Parent.Connection = connection;
            Parent.FillCabinsGrid();
            Visible = false;
        }
    }
}
