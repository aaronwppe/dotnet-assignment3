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
    public partial class Form6 : Form
    {
        string[] cities = { "Pune", "Mumbai", "New Delhi", "Hyderabad" };
        public Form6()
        {
            InitializeComponent();

            CityComboBox.Items.AddRange(cities);
        }       

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedItem != null) 
                MessageBox.Show(CityComboBox.SelectedItem.ToString());
        }
    }
}
