using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                float temp = float.Parse(txtbox.Text);
                if (combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz skale!", "Achtung!", MessageBoxButtons.OK);
                }
                else if (combobox.SelectedIndex == 0) // celsiujsz
                {
                    result1.Text = temp.ToString(); 
                    result2.Text = ((temp * 1.8) + 32).ToString();
                    result3.Text = (temp + 273.15).ToString();
                }
                else if (combobox.SelectedIndex == 1) // fahrenheit
                {
                    result1.Text = ((temp - 32)/1.8).ToString();
                    result2.Text = temp.ToString();
                    result3.Text = ((temp + 459.67) * 5/9).ToString();
                } else if (combobox.SelectedIndex == 2) // kelvin
                {
                    result1.Text = (temp - 273.15).ToString();
                    result2.Text = ((temp * 1.8) - 459.67).ToString();
                    result3.Text = temp.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Textbox jest pusty!", "Achtung!", MessageBoxButtons.OK);
            }

        }

    }
}
