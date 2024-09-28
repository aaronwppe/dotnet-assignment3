namespace dotnet_assignment3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateLabel.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }
    }
}
