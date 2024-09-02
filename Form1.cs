namespace dotnet_assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetNumbers(out int n1, out int n2)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GetNumbers(out int n1, out int n2);
            MessageBox.Show((n1 + n2).ToString());
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            GetNumbers(out int n1, out int n2);
            MessageBox.Show((n1 - n2).ToString());
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            GetNumbers(out int n1, out int n2);
            MessageBox.Show((n1 * n2).ToString());
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            GetNumbers(out int n1, out int n2);
            string res;

            if (n2 == 0)
                res = "Undefined!";
            else
                res = (n1 / n2).ToString();

            MessageBox.Show(res);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
