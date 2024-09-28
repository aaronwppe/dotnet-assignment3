namespace dotnet_assignment3
{
    public partial class Form4 : Form
    {
        int[] arr = { 23, 55, 98, 44, 20 };

        public Form4()
        {
            InitializeComponent();
            DisplayArrayButton_Click(this, EventArgs.Empty);
            MaxButton_Click(this, EventArgs.Empty);
            SumButton_Click(this, EventArgs.Empty);
        }

        private void DisplayArrayButton_Click(object sender, EventArgs e)
        {
            string res = string.Empty;

            foreach (int i in arr) 
            {
                res += i + Environment.NewLine;
            }

            textBox1.Text = res;
        }

        private int[] GetArray()
        {
             return Array.ConvertAll(textBox1.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = GetArray().Max().ToString();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            textBox3.Text = GetArray().Sum().ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
