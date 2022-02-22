using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_6._2
{

    public partial class Form2 : Form
    {
        #region
        CarRepository repository;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            repository = new CarRepository();
            carGrid.DataSource = repository.GetCars();
            btnSubmitNew.Enabled = false;
            btnUpdateRec.Enabled = false;
            cmbYear.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            cmbStatus.Items.AddRange(new string[] { "In Stock", "Sold" });
            cmbColor.Items.AddRange(new string[] { "Black", "White", "Gray", "Blue", "Red", "Silver", "Orange" });


        }
        #endregion

        #region
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtVehVin.Clear();
            txtVehVin.ReadOnly = false;
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            cmbYear.Items.Clear();
            for (int i = 1990; i < DateTime.Now.Year + 1; i++)
            {
                cmbYear.Items.Add(i);
            }
            
            btnSubmitNew.Enabled = true;
      


        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
           
           
            var id = carGrid.CurrentRow.Cells[0].Value;
            var cartoupdate = repository.FindCar((string)id);
            txtVehVin.Text = cartoupdate.Vin.ToString();
            txtMake.Text = cartoupdate.Make.ToString();
            txtModel.Text = cartoupdate.Model.ToString();
            txtPrice.Text = cartoupdate.Price.ToString();
            cmbYear.Text = cartoupdate.Year.ToString();
            cmbColor.Text= cartoupdate.Color.ToString();
            cmbStatus.Text= cartoupdate.Status.ToString();

            btnUpdateRec.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = carGrid.CurrentRow.Cells[0].Value;
            var cartodel = repository.FindCar((string)id);
            repository.DeleteRecord(cartodel);
            MessageBox.Show("Record is deleted");
        }

        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            if (txtVehVin.Text != string.Empty && txtMake.Text != string.Empty && txtModel.Text != string.Empty && txtPrice.Text != string.Empty && cmbColor.Text != string.Empty && cmbYear.Text != string.Empty && cmbStatus.Text != string.Empty)
            { 
                var newcar = new Car();
                newcar.Vin = txtVehVin.Text;
                newcar.Make = txtMake.Text;
                newcar.Model = txtModel.Text;
                newcar.Color = cmbColor.SelectedItem.ToString();
                newcar.Year = Convert.ToInt32(cmbYear.Text);
                newcar.Price = Convert.ToDecimal(txtPrice.Text);
                newcar.Status = cmbStatus.SelectedItem.ToString();
                repository.AddRecord(newcar);
                Clear();


            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }
            

        }

        private void btnUpdateRec_Click(object sender, EventArgs e)
        {
            var id = txtVehVin.Text;
            var cartoupdate = repository.FindCar(id);
            cartoupdate.Make = txtMake.Text;
            cartoupdate.Model = txtModel.Text;
            cartoupdate.Price = Convert.ToDecimal(txtPrice.Text);
            cartoupdate.Color = cmbColor.SelectedItem.ToString();
            cartoupdate.Year = Convert.ToInt32(cmbYear.Text);
            cartoupdate.Status = cmbStatus.SelectedItem.ToString();
            repository.UpdateRecord(id, cartoupdate);
            Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carGrid.DataSource = null;
            carGrid.DataSource = repository.GetCars();
            btnSubmitNew.Enabled = false;
            btnUpdateRec.Enabled = false;   

        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {

            string searchString = "In Stock";
            foreach (DataGridViewRow row in carGrid.Rows)
            {
                if (row.Cells["Status"].Value.ToString().Contains(searchString))
                {
                    
                    carGrid.Rows[row.Index].Visible = true;
                    int index = row.Index;
                    carGrid.FirstDisplayedScrollingRowIndex = index;

                }
                else
                {

                    int index = row.Index;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[carGrid.DataSource];
                    currencyManager1.SuspendBinding();
                    carGrid.Rows[row.Index].Visible = false;
                    currencyManager1.ResumeBinding();
                }

            }


        }

        private void btnSold_Click(object sender, EventArgs e)
        {

            string searchString = "Sold";
            foreach (DataGridViewRow row in carGrid.Rows)
            {
                if (row.Cells["Status"].Value.ToString().Contains(searchString))
                {
                        
                        carGrid.Rows[row.Index].Visible = true;
                        int index = row.Index;
                        carGrid.FirstDisplayedScrollingRowIndex = index;
                        
                }
                else
                {

                    int index = row.Index;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[carGrid.DataSource];
                    currencyManager1.SuspendBinding();
                    carGrid.Rows[row.Index].Visible = false;
                    currencyManager1.ResumeBinding();
                }
                
            }

            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Hide();
        }
        #endregion

        #region
        private void Clear()
        {
            txtVehVin.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            cmbColor.SelectedIndex = -1;
            cmbColor.DataSource = null;
            cmbYear.SelectedIndex = -1;
            cmbYear.DataSource = null;
            cmbStatus.SelectedIndex = -1;
            cmbStatus.DataSource = null;

        }


        private void txtVehVin_Leave(object sender, EventArgs e)
        {

            if (txtVehVin.Text=="")
            {
                string vin = string.Empty;
                MessageBox.Show("Please enter the Vin Number");
            }
            else if ((txtVehVin.Text.Length > 37))
            {
                txtVehVin.Clear();
                MessageBox.Show("Please check the Vin number, it cannot exceed 17 Characters");
                txtVehVin.Focus();
            }
            else
                return;
        }

        private void txtMake_Leave(object sender, EventArgs e)
        {
            if (txtMake.Text == "")
            {
                string make = string.Empty;
                MessageBox.Show("Please enter the Make");
            }
            else if ((txtMake.Text.Length > 10))
            {
                txtMake.Clear();
                MessageBox.Show("Please check the Name of the Make, it cannot exceed 10 Characters");
                txtMake.Focus();
            }
            else
                return;
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                string model = string.Empty;
                MessageBox.Show("Please enter the Model");
            }
            else if ((txtModel.Text.Length > 10))
            {
                txtModel.Clear();
                MessageBox.Show("Please check the Name of the Model, it cannot exceed 10 Characters");
                txtModel.Focus();
            }
            else
                return;
        }

        private void cmbColor_Leave(object sender, EventArgs e)
        {
            if (cmbColor.Text == "")
            {
                string color = string.Empty;
                MessageBox.Show("Please ensure to select the color");
            }

        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Please ensure to enter the Price in decimal");
            }
      
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "")
            {
                string status = string.Empty;
                MessageBox.Show("Please ensure to select the status of the vehicle you are entering");
                
            }

        }
        private void cmbYear_Leave(object sender, EventArgs e)
        {
            if (cmbYear.Text == "")
            {
                string year = string.Empty;
                MessageBox.Show("Please ensure to select the year of the vehicle");
                cmbYear.Focus();
            }


        }
        #endregion
    }

}
