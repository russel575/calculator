using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirstNumber.Text);
            int second = Convert.ToInt32(secondNumberTextBox.Text);
            int result = first + second;
            if(FirstNumber.Text == "")
            {
                MessageBox.Show("Please Enter First Number");
            }else if (secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Second Number");
            }
            else
            {
                richTextBox1.Text = ("" + result);
            }
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirstNumber.Text);
            int second = Convert.ToInt32(secondNumberTextBox.Text);
            int result = first - second;
            if (FirstNumber.Text == "")
            {
                MessageBox.Show("Please Enter First Number");
            }
            else if (secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Second Number");
            }
            else
            {
                richTextBox1.Text = ("" + result);
            }
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirstNumber.Text);
            int second = Convert.ToInt32(secondNumberTextBox.Text);
            int result = first * second;
            if (FirstNumber.Text == "")
            {
                MessageBox.Show("Please Enter First Number");
            }
            else if (secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Second Number");
            }
            else
            {
                richTextBox1.Text = ("" + result);
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirstNumber.Text);
            int second = Convert.ToInt32(secondNumberTextBox.Text);
            int result = first / second;
            if (FirstNumber.Text == "")
            {
                MessageBox.Show("Please Enter First Number");
            }
            else if (secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Second Number");
            }
            else
            {
                richTextBox1.Text = ("" + result);
            }
        }
    }
}
