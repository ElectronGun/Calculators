namespace Pocket_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char oper;
        double num1;   //variable to hold first number
        double num2;    //variable to hold second number
        double result;   //variable to hold result

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;   //clears the contents of the textbox1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)   //checks if the text in textBox1 is equal to 0 and if textBox1 is not null
            {
                textBox1.Text = "1";   //if both conditions are true, sets the text in textBox1 to 1
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";   //if either not true then set textbox1 to 1 ontop of whatever was there before
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = '/';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            oper = '*';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);   //when operator and equals press execute method

            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    break;
                case '/':
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}