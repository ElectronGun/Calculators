using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_BMI_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            bool validnum1 = double.TryParse(textBox1.Text, out num1);   //parse to determine if number - tryparse converts to double prec float #, null & letters provide false output
            bool validnum2 = double.TryParse(textBox2.Text, out num2);   //parse to determine if number - tryparse converts to double prec float #, null & letters provide false output

            if (validnum1 && validnum2)   //parse the input text boxes as double values otherwise error
            {

                double sum = num1 + num2;   //calculate sum and display in output label 1
                label1.Text = "Result: " + sum.ToString();
            }
            else
            {
                // Display an error message if the input is invalid
                label1.Text = "Error: Please enter valid numbers.";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            bool validnum1 = double.TryParse(textBox1.Text, out num1);   //parse to determine if number
            bool validnum2 = double.TryParse(textBox2.Text, out num2);   //parse to determine if number

            if (validnum1 && validnum2)   //parse the input text boxes as double values otherwise error
            {

                double sum = num1 - num2;   //calculate subtraction and display in output label 1
                label1.Text = "Result: " + sum.ToString();
            }
            else
            {
                // Display an error message if the input is invalid
                label1.Text = "Error: Please enter valid numbers.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            bool validnum1 = double.TryParse(textBox1.Text, out num1);   //parse to determine if number
            bool validnum2 = double.TryParse(textBox2.Text, out num2);   //parse to determine if number

            if (validnum1 && validnum2)   //parse the input text boxes as double values otherwise error
            {

                double sum = num1 * num2;   //calculate multiplication and display in output label 1
                label1.Text = "Result: " + sum.ToString();
            }
            else
            {
                // Display an error message if the input is invalid
                label1.Text = "Error: Please enter valid numbers.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            bool validnum1 = double.TryParse(textBox1.Text, out num1);   //parse to determine if number
            bool validnum2 = double.TryParse(textBox2.Text, out num2);   //parse to determine if number

            if (validnum1 && validnum2)   //parse the input text boxes as double values otherwise error
            {
                if (num2 == 0)   //textbox2 CANNOT be zero, textbox1 CAN be zero
                {

                    label1.Text = "Division by zero detected: Additional schooling required.";   //error message if division by zero is detected :)

                }
                else
                {
                    double sum = num1 / num2;   //calculate division and display in output label 1
                    label1.Text = "Result: " + sum.ToString();
                }
            }
            else
            {

                label1.Text = "Please enter valid numbers.";   //error message if the input is invalid
            }
        }
    }
}

