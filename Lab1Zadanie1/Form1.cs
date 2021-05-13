using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(tbX.Text);
                float y = float.Parse(tbY.Text);
                float z = float.Parse(tbZ.Text);
                tbWynik.Text = (x + y + z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędną liczbę!", "Achtung!", MessageBoxButtons.OK);
            }
        }

        private void btnIloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(tbX.Text);
                float y = float.Parse(tbY.Text);
                float z = float.Parse(tbZ.Text);
                tbWynik.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędną liczbę!", "Achtung!", MessageBoxButtons.OK);
            }

        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
