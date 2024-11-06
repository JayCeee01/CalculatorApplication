using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CalculatorApplication.CalculatorClass;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        

        public FrmCalculator()
        {
            InitializeComponent();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

        }

        public void CalculateTotal()
        {
            try
            {
                CalculatorClass cal = new CalculatorClass();
                double num1 = double.Parse(txtBoxInput1.Text);
                double num2 = double.Parse(txtBoxInput2.Text);
                //cal.formula = new Formula(cal.GetSum);

                if(cbOperator.SelectedIndex == 0) {

                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                } 
                else if(cbOperator.SelectedIndex == 1)
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                }
                else if (cbOperator.SelectedIndex == 2)
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                }
                else if (cbOperator.SelectedIndex == 3)
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                }
                else
                {
                    MessageBox.Show("Please enter the correct input.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please enter the correct input.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
