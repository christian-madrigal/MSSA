using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_4._3
{
    public partial class Form1 : Form
    {
        ArrayList Stulist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stulist = new ArrayList();
            Stulist.Add(new Students() { Stuid = 1, Fname = "Christia", Lname = "Madrigal", Address = "123 Main Street", Grade = Grades.A, Month = MonthofAdmission.April });
            ComboGrade.DataSource = Enum.GetValues(typeof(Grades));
            ComboMonth.DataSource = Enum.GetValues(typeof(MonthofAdmission));
            grpStu.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Stulist.RemoveAt(stuGrid.CurrentRow.Index);
            RefreshData();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpStu.Visible = true;

            if (txtStuid.Text != string.Empty && txtFname.Text != string.Empty && txtLname.Text != string.Empty && txtAddy.Text !=string.Empty)
            {
                Students newStu = new Students();
                newStu.Stuid = Int32.Parse(txtStuid.Text);
                newStu.Fname = txtFname.Text;
                newStu.Lname = txtLname.Text;
                newStu.Address = txtAddy.Text;
                newStu.Grade = (Grades)ComboGrade.SelectedIndex;
                newStu.Month = (MonthofAdmission)ComboMonth.SelectedIndex;
                Stulist.Add(newStu);
            }
            RefreshData();
        }
        private void RefreshData()
        {
            txtStuid.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddy.Clear();
            stuGrid.DataSource = null;
            stuGrid.DataSource = Stulist;
        }
    }
}
