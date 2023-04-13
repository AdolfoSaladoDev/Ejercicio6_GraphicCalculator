namespace Calculator
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TextBox();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.CausesValidation = false;
            this.Result.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(10, 21);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result.ShortcutsEnabled = false;
            this.Result.Size = new System.Drawing.Size(358, 62);
            this.Result.TabIndex = 0;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(10, 102);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(85, 100);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(103, 102);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(85, 100);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(194, 102);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(85, 100);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            // 
            // Pow
            // 
            this.Pow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pow.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pow.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pow.Location = new System.Drawing.Point(285, 102);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(85, 100);
            this.Pow.TabIndex = 4;
            this.Pow.Text = "^";
            this.Pow.UseVisualStyleBackColor = false;
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Divide.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Divide.Location = new System.Drawing.Point(285, 208);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(85, 100);
            this.Divide.TabIndex = 8;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(194, 208);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(85, 100);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(103, 208);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(85, 100);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(10, 208);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(85, 100);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Multiply.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiply.Location = new System.Drawing.Point(285, 314);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(85, 100);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(194, 314);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(85, 100);
            this.Three.TabIndex = 11;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.button10_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Two.Location = new System.Drawing.Point(101, 314);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(85, 100);
            this.Two.TabIndex = 10;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.LightSteelBlue;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(10, 314);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(85, 100);
            this.One.TabIndex = 9;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Subtraction.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Subtraction.Location = new System.Drawing.Point(285, 423);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(85, 100);
            this.Subtraction.TabIndex = 16;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.button13_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dot.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dot.Location = new System.Drawing.Point(194, 423);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(85, 100);
            this.Dot.TabIndex = 15;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.button14_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(101, 423);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(85, 100);
            this.Zero.TabIndex = 14;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.button15_Click);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clean.Location = new System.Drawing.Point(10, 423);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(85, 100);
            this.Clean.TabIndex = 13;
            this.Clean.Text = "C";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.button16_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.Aquamarine;
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equals.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equals.Location = new System.Drawing.Point(10, 529);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(269, 100);
            this.Equals.TabIndex = 17;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.button17_Click);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sum.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sum.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sum.Location = new System.Drawing.Point(285, 529);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(85, 100);
            this.Sum.TabIndex = 20;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.button20_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Result;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Pow;
        private Button Divide;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Multiply;
        private Button Three;
        private Button Two;
        private Button One;
        private Button Subtraction;
        private Button Dot;
        private Button Zero;
        private Button Clean;
        private Button Equals;
        private Button Sum;
    }
}