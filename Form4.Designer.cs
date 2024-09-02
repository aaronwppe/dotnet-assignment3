namespace dotnet_assignment3
{
    partial class Form4
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
            MaxButton = new Button();
            SumButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ClearButton = new Button();
            ExitButton = new Button();
            panel1 = new Panel();
            DisplayArrayButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 132);
            textBox1.TabIndex = 0;
            // 
            // MaxButton
            // 
            MaxButton.Location = new Point(225, 37);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(94, 29);
            MaxButton.TabIndex = 1;
            MaxButton.Text = "Maximum";
            MaxButton.UseVisualStyleBackColor = true;
            MaxButton.Click += MaxButton_Click;
            // 
            // SumButton
            // 
            SumButton.Location = new Point(225, 95);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(94, 29);
            SumButton.TabIndex = 2;
            SumButton.Text = "Sum";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(225, 158);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(335, 158);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DisplayArrayButton);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 191);
            panel1.TabIndex = 7;
            // 
            // DisplayArrayButton
            // 
            DisplayArrayButton.Location = new Point(19, 8);
            DisplayArrayButton.Name = "DisplayArrayButton";
            DisplayArrayButton.Size = new Size(134, 29);
            DisplayArrayButton.TabIndex = 1;
            DisplayArrayButton.Text = "Display Array";
            DisplayArrayButton.UseVisualStyleBackColor = true;
            DisplayArrayButton.Click += DisplayArrayButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(SumButton);
            Controls.Add(MaxButton);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button MaxButton;
        private Button SumButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button ClearButton;
        private Button ExitButton;
        private Panel panel1;
        private Button DisplayArrayButton;
    }
}