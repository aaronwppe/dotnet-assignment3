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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private bool Armstrong(int num)
        {
            int res = 0, power = num.ToString().Length;

            for (int n = num; n > 0; n /= 10)
            {
                res += (int) Math.Pow((n % 10), power); 
            }

            if (num == res)
                return true;
            else
                return false;
        }

        private bool Palindrome(int num)
        {
            string n1 = num.ToString(), n2 = new string (n1.Reverse().ToArray());

            if (n1.Equals(n2))
                return true;
            else
                return false;
        }

        private bool Prime(int num)
        {
            if (num < 2) 
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int n;

            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                return;
            }
            
            string res = string.Empty;

            if (ArmstrongRadioButton.Checked)
                res = "Armstrong: " + Armstrong(n).ToString();

            else if (PalindromeRadioButton.Checked)
                res = "Palindrome: " + Palindrome(n).ToString();

            else if (PrimeRadioButton.Checked)
                res = "Prime: " + Prime(n).ToString();

            MessageBox.Show(res);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
