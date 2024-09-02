namespace dotnet_assignment3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AddButton = new Button();
            SubtractButton = new Button();
            MultiplyButton = new Button();
            DivideButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "No. 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "No. 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(269, 11);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(269, 46);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(94, 29);
            SubtractButton.TabIndex = 5;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(269, 81);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(94, 29);
            MultiplyButton.TabIndex = 6;
            MultiplyButton.Text = "Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(269, 116);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(94, 29);
            DivideButton.TabIndex = 7;
            DivideButton.Text = "Divide";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(390, 81);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(390, 116);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DivideButton);
            Controls.Add(MultiplyButton);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddButton;
        private Button SubtractButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}
