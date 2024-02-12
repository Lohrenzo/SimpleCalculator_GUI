using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            if (radioButtonPlus.Checked == true)
            {
                double result = num1 + num2;
                textBox3.Text = result.ToString();
            } else if (radioButtonMinus.Checked == true)
            {
                double result = num1 - num2;
                textBox3.Text = result.ToString();
            } else if (radioButtonTimes.Checked == true)
            {
                double result = num1 * num2;
                textBox3.Text = result.ToString();
            } else if (radioButtonOver.Checked == true)
            {
                double result = num1 / num2;
                textBox3.Text = result.ToString();
            } else if (radioButtonPower.Checked == true)
            {
                double result = 1;
                for (int i = 1; i <= num2; i++)
                {
                    result *= num1;
                }
                textBox3.Text = result.ToString();
            }
        }
    }
}
