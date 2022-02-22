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
    public partial class Form1 : Form
    {
        int attempt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtPass.PasswordChar = '*';
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (attempt < 4)
            {
                string username = txtUser.Text;
                string password = txtPass.Text;
                if ((this.txtUser.Text == "Admin") && (this.txtPass.Text == "Password"))
                {

                    (new Form2()).Show(); this.Hide();
                }
                else 
                {
                    txtPass.Clear();
                    txtUser.Clear();
                    MessageBox.Show($"You have entered the wrong Username and/or Password. Please check to ensure you are using case sensitive letters.This is {attempt} of 3 attempts");

                }
            }
            else if (attempt == 4)
            {
                MessageBox.Show("You have exceeded the of tries and you do not have access to use this system");



            }
            attempt++;
           
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
