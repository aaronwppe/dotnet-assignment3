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
    public partial class Form8 : Form
    {
        string[] arr = { "23", "55", "98", "44", "20" };
        public Form8()
        {
            InitializeComponent();
        }

        private void DisplayArrayButton_Click(object sender, EventArgs e)
        {
            ListBox.Items.AddRange(arr);
        }

        private int[] GetArray()
        {
            int[] arr = new int[ListBox.Items.Count];

            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(ListBox.Items[i].ToString());
            }
            return arr;
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetArray().Max().ToString();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = GetArray().Sum().ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            ListBox.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}