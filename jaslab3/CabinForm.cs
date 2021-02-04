using System;
using System.Windows.Forms;

namespace jaslab3
{
    public partial class CabinForm : Form
    {
        public MainForm Parent = null;
        public int Row;

        public CabinForm()
        {
            InitializeComponent();
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            Parent.AddCabin(nameBox.Text, int.Parse(squareBox.Text), classBox.Text);
            Parent.FillCabinsGrid();
            Visible = false;
        }

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            Parent.UpdateCabin(Row, nameBox.Text, int.Parse(squareBox.Text), classBox.Text);
            Parent.FillCabinsGrid();
            Visible = false;
        }

        public void Reset(bool edit, string name, string square, string className)
        {
            editButton.Visible = edit;
            addButton.Visible = !edit;
            nameBox.Text = name;
            squareBox.Text = square;
            classBox.Text = className;
        }

    }
}