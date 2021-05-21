using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Zadanie1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e) {
            try {
                if(!string.IsNullOrWhiteSpace(this.txtBoxWzrost.Text)) {
                    if (this.checkBoxStandardowa.Checked) {
                        this.lblResult1.Text = "Standartowa: " + (int.Parse(this.txtBoxWzrost.Text) - 100).ToString() + " kg"; // waga standartowa
                    } else {
                        throw new Exception("Należy wybrać wagę!");
                    }
                    if (this.checkBoxIdealna.Checked) {
                        int standardowa = int.Parse(this.txtBoxWzrost.Text) - 100;
                        if (this.rdBtnKobieta.Checked) {
                            this.lblResult2.Text = "Idealna: " + (Convert.ToDouble(standardowa) * 0.85).ToString("0.000") + " kg"; // waga idealna dla kobiet
                        } else if (this.rdBtnMez.Checked) {
                            this.lblResult2.Text = "Idealna: " + (Convert.ToDouble(standardowa) * 0.9).ToString("0.000") + " kg"; // waga idealna dla mezczyzn
                        } else {
                            throw new Exception("Dla idealnej wagi należy wybrać płeć!");
                        }
                    }
                } else {
                    throw new Exception("Należy podać wagę!");
                }
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Uwaga!", MessageBoxButtons.OK);
            }
        }
    }
}
