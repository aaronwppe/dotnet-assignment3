namespace dotnet_assignment3
{
    partial class Form5
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
            label1 = new Label();
            PalindromeRadioButton = new RadioButton();
            PrimeRadioButton = new RadioButton();
            ArmstrongRadioButton = new RadioButton();
            textBox1 = new TextBox();
            OkButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Number";
            // 
            // PalindromeRadioButton
            // 
            PalindromeRadioButton.AutoSize = true;
            PalindromeRadioButton.Location = new Point(308, 17);
            PalindromeRadioButton.Name = "PalindromeRadioButton";
            PalindromeRadioButton.Size = new Size(105, 24);
            PalindromeRadioButton.TabIndex = 1;
            PalindromeRadioButton.TabStop = true;
            PalindromeRadioButton.Text = "Palindrome";
            PalindromeRadioButton.UseVisualStyleBackColor = true;
            // 
            // PrimeRadioButton
            // 
            PrimeRadioButton.AutoSize = true;
            PrimeRadioButton.Location = new Point(308, 47);
            PrimeRadioButton.Name = "PrimeRadioButton";
            PrimeRadioButton.Size = new Size(68, 24);
            PrimeRadioButton.TabIndex = 2;
            PrimeRadioButton.TabStop = true;
            PrimeRadioButton.Text = "Prime";
            PrimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ArmstrongRadioButton
            // 
            ArmstrongRadioButton.AutoSize = true;
            ArmstrongRadioButton.Location = new Point(308, 77);
            ArmstrongRadioButton.Name = "ArmstrongRadioButton";
            ArmstrongRadioButton.Size = new Size(100, 24);
            ArmstrongRadioButton.TabIndex = 3;
            ArmstrongRadioButton.TabStop = true;
            ArmstrongRadioButton.Text = "Armstrong";
            ArmstrongRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(68, 72);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 5;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(168, 72);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(OkButton);
            Controls.Add(textBox1);
            Controls.Add(ArmstrongRadioButton);
            Controls.Add(PrimeRadioButton);
            Controls.Add(PalindromeRadioButton);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton PalindromeRadioButton;
        private RadioButton PrimeRadioButton;
        private RadioButton ArmstrongRadioButton;
        private TextBox textBox1;
        private Button OkButton;
        private Button ExitButton;
    }
}