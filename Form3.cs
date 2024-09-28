using RadioButton = System.Windows.Forms.RadioButton;
using CheckBox = System.Windows.Forms.CheckBox;

namespace dotnet_assignment3
{
    public partial class Form3 : Form
    {
        RadioButton[] radioButtons;
        CheckBox[] checkBoxes;

        public Form3()
        {
            InitializeComponent();

            radioButtons = new RadioButton[] { McaRadioButton, MbaRadioButton, McmRadioButton, BcaRadioButton };
            checkBoxes = new CheckBox[] {VbCheckBox, CsCheckBox, JsCheckBox };
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string res = $"Name: {textBox1.Text}\n";

            res += "Stream: ";

            foreach (RadioButton button in radioButtons)
            {
                if (button.Checked)
                {
                    res += button.Text;
                    break;
                }
            }

            res += "\nComputer Knowledge: ";

            foreach (CheckBox box in checkBoxes)
            {
                if (box.Checked)
                {
                    res += box.Text + " ";
                }
            }

            MessageBox.Show(res); 
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            foreach(RadioButton button in radioButtons)
                button.Checked = false;

            foreach (CheckBox box in checkBoxes)
                box.Checked = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
