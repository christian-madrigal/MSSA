using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            if (decimal.TryParse(txtNum1.Text, out num1) == true && decimal.TryParse(txtNum2.Text, out num2) == true)
            {


                Calculator newcalculator = new Calculator();
                txtTotal.Text = newcalculator.add(num1, num2).ToString();

            }
            if (decimal.TryParse(txtTotal.Text, out num1) == true)
                MessageBox.Show($" The answer is {txtTotal.Text}, click Ok to input new numbers and use any of the other functions");
            else if (Decimal.TryParse(txtNum1.Text, out num1) != true || Decimal.TryParse(txtNum2.Text, out num2) != true)
                MessageBox.Show("Please ensure you are inputting a decimal in each box before pressing the function you want.");
            txtNum1.Clear();
            txtNum2.Clear();
            txtTotal.Clear();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            if (decimal.TryParse(txtNum1.Text, out num1) == true && decimal.TryParse(txtNum2.Text, out num2) == true)
            {


                Calculator newcalculator = new Calculator();
                txtTotal.Text = newcalculator.substract(num1, num2).ToString();
            }
            if (decimal.TryParse(txtTotal.Text, out num1) == true)
                MessageBox.Show($" The answer is {txtTotal.Text}, click Ok to input new numbers and use any of the other functions");
            else if (Decimal.TryParse(txtNum1.Text, out num1) != true || Decimal.TryParse(txtNum2.Text, out num2) != true)
                MessageBox.Show("Please ensure you are inputting a decimal in each box before pressing the function you want.");
            txtNum1.Clear();
            txtNum2.Clear();
            txtTotal.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            if (decimal.TryParse(txtNum1.Text, out num1) == true && decimal.TryParse(txtNum2.Text, out num2) == true)
            {


                Calculator newcalculator = new Calculator();
                txtTotal.Text = newcalculator.multiply(num1, num2).ToString();
            }
            if (decimal.TryParse(txtTotal.Text, out num1) == true)
                MessageBox.Show($" The answer is {txtTotal.Text}, click Ok to input new numbers and use any of the other functions");
            else if (Decimal.TryParse(txtNum1.Text, out num1) != true || Decimal.TryParse(txtNum2.Text, out num2) != true)
                MessageBox.Show("Please ensure you are inputting a decimal in each box before pressing the function you want.");
            txtNum1.Clear();
            txtNum2.Clear();
            txtTotal.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            if (decimal.TryParse(txtNum1.Text, out num1) == true && decimal.TryParse(txtNum2.Text, out num2) == true)
            {


                Calculator newcalculator = new Calculator();
                txtTotal.Text = newcalculator.divide(num1, num2).ToString();
            }
            if (decimal.TryParse(txtTotal.Text, out num1) == true)
                MessageBox.Show($" The answer is {txtTotal.Text}, click Ok to input new numbers and use any of the other functions");
            else if (Decimal.TryParse(txtNum1.Text, out num1) != true || Decimal.TryParse(txtNum2.Text, out num2) != true)
                MessageBox.Show("Please ensure you are inputting a decimal in each box before pressing the function you want.");
            txtNum1.Clear();
            txtNum2.Clear();
            txtTotal.Clear();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Hide();
        }
    }
}
