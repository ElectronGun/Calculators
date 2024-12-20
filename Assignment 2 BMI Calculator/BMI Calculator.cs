namespace Assignment_2_BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double weight = 0;   //initialize to zero
            double height = 0;   //initialize to zero
            bool validWeight = double.TryParse(textBox1.Text, out weight);   //parse to determine if number
            bool validHeight = double.TryParse(textBox2.Text, out height);   //parse to determine if number


            if (validWeight && validHeight)   // Check if both inputs valid, calculate BMI and output
            {
                double bmi = (703 * weight) / height / height;  // Calculate the BMI
                label4.Text = bmi.ToString("F2");   // Display the result
            }
            else
            {
                label4.Text = "Enter valid numbers for weight and height";   // Display an error message in the label 4
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
