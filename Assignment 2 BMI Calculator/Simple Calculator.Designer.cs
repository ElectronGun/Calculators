namespace Assignment_2_BMI_Calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 43);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 43);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(77, 186);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 186);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(77, 299);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 4;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(364, 299);
            button4.Name = "button4";
            button4.Size = new Size(169, 52);
            button4.TabIndex = 5;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 404);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 6;
            label1.Text = "Calculation Output";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 1044);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Simple Calculator";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}