namespace dotnet_assignment3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ConcatenateButton = new Button();
            ReverseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "String 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "String 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Result:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // ConcatenateButton
            // 
            ConcatenateButton.Location = new Point(12, 159);
            ConcatenateButton.Name = "ConcatenateButton";
            ConcatenateButton.Size = new Size(105, 29);
            ConcatenateButton.TabIndex = 6;
            ConcatenateButton.Text = "Concatenate";
            ConcatenateButton.UseVisualStyleBackColor = true;
            ConcatenateButton.Click += ConcatenateButton_Click;
            // 
            // ReverseButton
            // 
            ReverseButton.Location = new Point(123, 159);
            ReverseButton.Name = "ReverseButton";
            ReverseButton.Size = new Size(105, 29);
            ReverseButton.TabIndex = 7;
            ReverseButton.Text = "Reverse";
            ReverseButton.UseVisualStyleBackColor = true;
            ReverseButton.Click += ReverseButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReverseButton);
            Controls.Add(ConcatenateButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button ConcatenateButton;
        private Button ReverseButton;
    }
}