using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_assignment3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ConcatenateButton_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string res = textBox1.Text + textBox2.Text;
            textBox3.Text = new string(res.Reverse().ToArray());
        }
    }
}
