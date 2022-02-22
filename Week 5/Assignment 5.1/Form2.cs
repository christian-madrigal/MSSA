using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_5._1
{
    public partial class Form2 : Form
    {
        Dictionary<int, Employee> employee;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            empGrid.Visible = true;
            
            cmbDep.DataSource = Enum.GetValues(typeof(Department));

            employee = new Dictionary<int, Employee>();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text != string.Empty && txtFname.Text != string.Empty && txtLname.Text != string.Empty && cmbDep.Text != string.Empty && dateTimePicker1.Text != string.Empty && txtAge.Text != string.Empty && txtAddy.Text != string.Empty && txtPhone.Text != string.Empty)
            {
                Employee emp = new Employee();
                emp.EmpID = Int32.Parse(txtEmpId.Text);
                emp.FName = txtFname.Text;
                emp.LName = txtLname.Text;
                emp.Addy = txtAddy.Text;
                emp.Phone = (txtPhone.Text);
                emp.Dept = (Department)cmbDep.SelectedIndex;
                emp.Age = Int32.Parse(txtAge.Text);
                emp.Dob = dateTimePicker1.Value.Date;
                employee.Add(emp.EmpID, emp);
                empGrid.Visible = true;
                RefreshData();
                
             
            }
            else 
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }
            
         
            
            


        }
        private void RefreshData()
        {
            txtEmpId.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAge.Clear();
            txtAddy.Clear();
            txtPhone.Clear();
            empGrid.DataSource = null;
            empGrid.DataSource = employee.Values.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employee.Remove((int)empGrid.CurrentRow.Cells[0].Value);
            RefreshData();
            MessageBox.Show("Successfully deleted and entry");
        }

        private void btnReturntoMain_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            Employee emp = new Employee();
            emp.Dob = dateTimePicker1.Value;
            emp.Age = DateTime.Now.Year - emp.Dob.Year;
            txtAge.Text = emp.Age.ToString();
            txtAge.ReadOnly = true;
            if (dateTimePicker1.Value.Year > 2004)
            {
                MessageBox.Show("Employee must be at minimum 18 years old");

            }
            else
            {
                emp.Dob = dateTimePicker1.Value;


            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if ((txtPhone.Text.Length < 10) && (txtPhone.Text.Length > 0))
            {
                
                MessageBox.Show("Phone number must be 10 digits!");
                txtPhone.Focus();
            }
            if ((txtPhone.Text.Length > 10)) 
            {
                txtPhone.Clear();
                MessageBox.Show("Phone number must be 10 digits!");
                txtPhone.Focus();
            }

        }
    }
}
