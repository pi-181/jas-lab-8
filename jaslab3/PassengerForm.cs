using System;
using System.Windows.Forms;

namespace jaslab3
{
    public partial class PassengerForm : Form
    {
        public MainForm Parent = null;
        public string CabinName;
        public int CabinId;
        public int Row;

        public PassengerForm()
        {
            InitializeComponent();
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            Parent.AddPassenger(firstNameBox.Text, secondNameBox.Text, sexBox.Text, CabinId);
            Parent.FillPassengersGrid(CabinName);
            Visible = false;
        }

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            Parent.UpdatePassenger(Row, firstNameBox.Text, secondNameBox.Text, sexBox.Text);
            Parent.FillPassengersGrid(CabinName);
            Visible = false;
        }
        
        public void Reset(bool edit, string firstName, string secondName, string sex)
        {
            editButton.Visible = edit;
            addButton.Visible = !edit;
            firstNameBox.Text = firstName;
            secondNameBox.Text = secondName;
            sexBox.Text = sex;
        }
    }
}