using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        int num1, num2, result;
        string option = " ";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int v = int.Parse(b.Text);
            int val = int.Parse(textBox1.Text);
            val = val * 10 + v;
            textBox1.Text = val.ToString();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if(option == "+")
            {
                result = num1 + num2;
            }
            else if(option == "-")
            {
                result = num1 - num2;
            }
            else if (option == "*")
            {
                result = num1 * num2;
            }
            else if (option == "/")
            {
                result = num1 / num2;
            }
            else
            {
                MessageBox.Show("Please enter a value"); 
            }

            textBox1.Text = result.ToString();
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = sender as Button; 
            option = b.Text;
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            option = "";
        }
    }
}
