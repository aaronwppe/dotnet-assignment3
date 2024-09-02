namespace dotnet_assignment3
{
    partial class Form3
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
            textBox1 = new TextBox();
            SubmitButton = new Button();
            NewButton = new Button();
            ExitButton = new Button();
            groupBox1 = new GroupBox();
            McaRadioButton = new RadioButton();
            MbaRadioButton = new RadioButton();
            McmRadioButton = new RadioButton();
            BcaRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            JsCheckBox = new CheckBox();
            CsCheckBox = new CheckBox();
            VbCheckBox = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "STUDENT PROFILE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(49, 266);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(162, 266);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(94, 29);
            NewButton.TabIndex = 4;
            NewButton.Text = "NEW";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(281, 266);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(McaRadioButton);
            groupBox1.Controls.Add(MbaRadioButton);
            groupBox1.Controls.Add(McmRadioButton);
            groupBox1.Controls.Add(BcaRadioButton);
            groupBox1.Location = new Point(30, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 153);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stream";
            // 
            // McaRadioButton
            // 
            McaRadioButton.AutoSize = true;
            McaRadioButton.Location = new Point(6, 26);
            McaRadioButton.Name = "McaRadioButton";
            McaRadioButton.Size = new Size(62, 24);
            McaRadioButton.TabIndex = 7;
            McaRadioButton.TabStop = true;
            McaRadioButton.Text = "MCA";
            McaRadioButton.UseVisualStyleBackColor = true;
            // 
            // MbaRadioButton
            // 
            MbaRadioButton.AutoSize = true;
            MbaRadioButton.Location = new Point(6, 56);
            MbaRadioButton.Name = "MbaRadioButton";
            MbaRadioButton.Size = new Size(62, 24);
            MbaRadioButton.TabIndex = 8;
            MbaRadioButton.TabStop = true;
            MbaRadioButton.Text = "MBA";
            MbaRadioButton.UseVisualStyleBackColor = true;
            // 
            // McmRadioButton
            // 
            McmRadioButton.AutoSize = true;
            McmRadioButton.Location = new Point(6, 86);
            McmRadioButton.Name = "McmRadioButton";
            McmRadioButton.Size = new Size(65, 24);
            McmRadioButton.TabIndex = 9;
            McmRadioButton.TabStop = true;
            McmRadioButton.Text = "MCM";
            McmRadioButton.UseVisualStyleBackColor = true;
            // 
            // BcaRadioButton
            // 
            BcaRadioButton.AutoSize = true;
            BcaRadioButton.Location = new Point(6, 116);
            BcaRadioButton.Name = "BcaRadioButton";
            BcaRadioButton.Size = new Size(58, 24);
            BcaRadioButton.TabIndex = 10;
            BcaRadioButton.TabStop = true;
            BcaRadioButton.Text = "BCA";
            BcaRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(JsCheckBox);
            groupBox2.Controls.Add(CsCheckBox);
            groupBox2.Controls.Add(VbCheckBox);
            groupBox2.Location = new Point(247, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Computer Knowledge";
            // 
            // JsCheckBox
            // 
            JsCheckBox.AutoSize = true;
            JsCheckBox.Location = new Point(6, 95);
            JsCheckBox.Name = "JsCheckBox";
            JsCheckBox.Size = new Size(79, 24);
            JsCheckBox.TabIndex = 2;
            JsCheckBox.Text = "J# .NET";
            JsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CsCheckBox
            // 
            CsCheckBox.AutoSize = true;
            CsCheckBox.Location = new Point(6, 65);
            CsCheckBox.Name = "CsCheckBox";
            CsCheckBox.Size = new Size(83, 24);
            CsCheckBox.TabIndex = 1;
            CsCheckBox.Text = "C# .NET";
            CsCheckBox.UseVisualStyleBackColor = true;
            // 
            // VbCheckBox
            // 
            VbCheckBox.AutoSize = true;
            VbCheckBox.Location = new Point(6, 35);
            VbCheckBox.Name = "VbCheckBox";
            VbCheckBox.Size = new Size(83, 24);
            VbCheckBox.TabIndex = 0;
            VbCheckBox.Text = "VB .NET";
            VbCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ExitButton);
            Controls.Add(NewButton);
            Controls.Add(SubmitButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button SubmitButton;
        private Button NewButton;
        private Button ExitButton;
        private GroupBox groupBox1;
        private RadioButton MbaRadioButton;
        private RadioButton McmRadioButton;
        private RadioButton BcaRadioButton;
        private GroupBox groupBox2;
        private RadioButton McaRadioButton;
        private CheckBox JsCheckBox;
        private CheckBox CsCheckBox;
        private CheckBox VbCheckBox;
    }
}