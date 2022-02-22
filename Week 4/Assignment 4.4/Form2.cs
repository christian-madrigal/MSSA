using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._4
{
    public partial class Form2 : Form
    {
        List<Coffee> coffees;

        public Form2()
        {
            InitializeComponent();
        }

        private void coffeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            coffees = new List<Coffee>();
            coffees.Add(new Coffee() { OrderID = 1, Name = "Espresso", Size = "Large", Temp = "Ice", Price = 4.50M });

            gridCoffeeList.DataSource = coffees.ToList();
            cmbBean.DataSource = Enum.GetValues(typeof(Bean));
            cmbMilk.DataSource = Enum.GetValues(typeof(Dairy));
            grpCoffee.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpCoffee.Visible = true;

            if (txtOrderID.Text != string.Empty && txtName.Text!= string.Empty&&txtSize.Text!=string.Empty&&txtTemp.Text!=string.Empty)
            {
                Coffee newcoff = new Coffee();
                newcoff.OrderID = Int32.Parse(txtOrderID.Text);
                newcoff.Name = txtName.Text;
                newcoff.Size = txtSize.Text;
                newcoff.Temp = txtTemp.Text;
                newcoff.Beans = (Bean)cmbBean.SelectedIndex;
                newcoff.Milk = (Dairy)cmbMilk.SelectedIndex;
                newcoff.Price = decimal.Parse(txtPrice.Text);
                coffees.Add(newcoff);
            }
            RefreshData();
        }
        private void RefreshData()
        {
            txtOrderID.Clear();
            txtName.Clear();
            txtSize.Clear();
            txtTemp.Clear();
            txtPrice.Clear();
            gridCoffeeList.DataSource = null;
            gridCoffeeList.DataSource = coffees;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            coffees.RemoveAt(gridCoffeeList.CurrentRow.Index);
            RefreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Hide();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
