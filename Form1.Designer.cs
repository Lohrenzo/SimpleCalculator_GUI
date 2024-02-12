namespace Lab1_GUI
{
    partial class Form1
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
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonTimes = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.radioButtonOver = new System.Windows.Forms.RadioButton();
            this.radioButtonPower = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(314, 106);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPlus.TabIndex = 0;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(314, 129);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(28, 17);
            this.radioButtonMinus.TabIndex = 1;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimes
            // 
            this.radioButtonTimes.AutoSize = true;
            this.radioButtonTimes.Location = new System.Drawing.Point(314, 152);
            this.radioButtonTimes.Name = "radioButtonTimes";
            this.radioButtonTimes.Size = new System.Drawing.Size(30, 17);
            this.radioButtonTimes.TabIndex = 2;
            this.radioButtonTimes.TabStop = true;
            this.radioButtonTimes.Text = "x";
            this.radioButtonTimes.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(23, 54);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(53, 13);
            this.number1.TabIndex = 6;
            this.number1.Text = "Number 1";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Location = new System.Drawing.Point(23, 81);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(53, 13);
            this.number2.TabIndex = 7;
            this.number2.Text = "Number 2";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(23, 135);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 8;
            this.result.Text = "Result";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(93, 191);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // radioButtonOver
            // 
            this.radioButtonOver.AutoSize = true;
            this.radioButtonOver.Location = new System.Drawing.Point(314, 175);
            this.radioButtonOver.Name = "radioButtonOver";
            this.radioButtonOver.Size = new System.Drawing.Size(30, 17);
            this.radioButtonOver.TabIndex = 10;
            this.radioButtonOver.TabStop = true;
            this.radioButtonOver.Text = "/";
            this.radioButtonOver.UseVisualStyleBackColor = true;
            // 
            // radioButtonPower
            // 
            this.radioButtonPower.AutoSize = true;
            this.radioButtonPower.Location = new System.Drawing.Point(314, 198);
            this.radioButtonPower.Name = "radioButtonPower";
            this.radioButtonPower.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPower.TabIndex = 11;
            this.radioButtonPower.TabStop = true;
            this.radioButtonPower.Text = "^";
            this.radioButtonPower.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 309);
            this.Controls.Add(this.radioButtonPower);
            this.Controls.Add(this.radioButtonOver);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonTimes);
            this.Controls.Add(this.radioButtonMinus);
            this.Controls.Add(this.radioButtonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonTimes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RadioButton radioButtonOver;
        private System.Windows.Forms.RadioButton radioButtonPower;
    }
}

