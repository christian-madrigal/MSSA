using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace Assignment_5._3
{
    public partial class Form1 : Form
    {

        

        Employees emp = new Employees();
        Employees emp1 = new Employees();
        string filepath = @"C:\Files";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbPos.DataSource = Enum.GetValues(typeof(Position));
            cmbPos.SelectedIndex = -1;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
      
        }

        private void binaryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            if (txtEmpID.Text != string.Empty && txtName.Text != string.Empty && cmbPos.Text != string.Empty)
            {
                emp.EmpID = Int32.Parse(txtEmpID.Text);
                emp.Name = txtName.Text;
                emp.Pos = (Position)cmbPos.SelectedIndex;
                FileStream filesStream = new FileStream(@"C:\Files\Binary.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(filesStream, emp);
                MessageBox.Show($"Your information has been serialized and located in {filepath} ");
                filesStream.Close();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }
            
            
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
            if (txtEmpID.Text != string.Empty && txtName.Text != string.Empty && cmbPos.Text != string.Empty)
            {
                emp.EmpID = Int32.Parse(txtEmpID.Text);
                emp.Name = txtName.Text;
                emp.Pos = (Position)cmbPos.SelectedIndex;
                FileStream fileStream = new FileStream(@"C:\Files\JSONSTORE.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(emp.GetType());
                jsonSerializer.WriteObject(fileStream, emp);
                fileStream.Close();
                MessageBox.Show($"Your information has been JSONSerialized and located in {filepath} ");
                fileStream.Close();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (txtEmpID.Text != string.Empty && txtName.Text != string.Empty && cmbPos.Text != string.Empty)
            {
                emp.EmpID = Int32.Parse(txtEmpID.Text);
                emp.Name = txtName.Text;
                emp.Pos = (Position)cmbPos.SelectedIndex;
                FileStream fileStreamxml = new FileStream(@"C:\Files\empsml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fileStreamxml, emp);
                fileStreamxml.Close();
                MessageBox.Show($"Your information has been JSONSerialized and located in {filepath} ");
                fileStreamxml.Close();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"C:\Files\Binary.txt", FileMode.Open, FileAccess.Read);
            emp1 = (Employees)binaryFormatter.Deserialize(stream);
            MessageBox.Show($"Your information was Deserialize {emp1.EmpID}, {emp1.Name}, {emp1.Pos}");
            stream.Close();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(emp.GetType());
            FileStream fileStreamnew = new FileStream(@"C:\Files\JSONSTORE.txt", FileMode.Open, FileAccess.Read);
            emp1 = jsonSerializer.ReadObject(fileStreamnew) as Employees;
            fileStreamnew.Close();
            MessageBox.Show($"Your information was Deserialize {emp1.EmpID}, {emp1.Name}, {emp1.Pos}");
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            FileStream filestreamxmlnew = new FileStream(@"C:\Files\empsml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            emp1 = (Employees)soapFormatter.Deserialize(filestreamxmlnew);
            filestreamxmlnew.Close();
            MessageBox.Show($"Your information was Deserialize {emp1.EmpID}, {emp1.Name}, {emp1.Pos}");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RefreshData()
        {
            txtEmpID.Clear();
            txtName.Clear();
            cmbPos.ResetText();

        }
    }
}
