namespace dotnet_assignment3
{
    partial class Form8
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
            MaxButton = new Button();
            SumButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ListBox = new ListBox();
            DisplayArrayButton = new Button();
            SuspendLayout();
            // 
            // MaxButton
            // 
            MaxButton.Location = new Point(244, 49);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(94, 29);
            MaxButton.TabIndex = 0;
            MaxButton.Text = "Maximum";
            MaxButton.UseVisualStyleBackColor = true;
            MaxButton.Click += MaxButton_Click;
            // 
            // SumButton
            // 
            SumButton.Location = new Point(244, 93);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(94, 29);
            SumButton.TabIndex = 1;
            SumButton.Text = "Sum";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            ClearButton.Location = new Point(244, 139);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            ExitButton.Location = new Point(344, 139);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 27);
            textBox2.TabIndex = 5;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(88, 49);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(150, 124);
            ListBox.TabIndex = 6;
            // 
            // DisplayArrayButton
            // 
            DisplayArrayButton.Location = new Point(112, 14);
            DisplayArrayButton.Name = "DisplayArrayButton";
            DisplayArrayButton.Size = new Size(94, 29);
            DisplayArrayButton.TabIndex = 7;
            DisplayArrayButton.Text = "Display Array";
            DisplayArrayButton.UseVisualStyleBackColor = true;
            DisplayArrayButton.Click += DisplayArrayButton_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayArrayButton);
            Controls.Add(ListBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(SumButton);
            Controls.Add(MaxButton);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MaxButton;
        private Button SumButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox ListBox;
        private Button DisplayArrayButton;
    }
}