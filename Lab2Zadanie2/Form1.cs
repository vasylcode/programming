using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Zadanie2 {
    public partial class Form1 : Form {

        int wielkosc;
        Color kolor;

        public Form1() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) { 

            if (this.rdMala.Checked) { wielkosc = 9; }
            else if (this.rdDuza.Checked) { wielkosc = 17; }
            else if (this.rdBduza.Checked) { wielkosc = 20; }
            else { wielkosc = 18; }

            if (this.rdCzerwony.Checked) { kolor = Color.Red; }
            else if (this.rdNiebieski.Checked) { kolor = Color.Blue; }
            else if (this.rdOrange.Checked) { kolor = Color.Orange; }
            else { kolor = Color.Black;  }


            this.txtText.Font = new Font("Segoe UI", wielkosc);
            this.txtText.ForeColor = kolor;

            if (this.checkPogrubienie.Checked && !this.checkPochylenie.Checked && !this.checkPodrkeslenie.Checked) {
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Bold);
            } if (this.checkPochylenie.Checked && !this.checkPogrubienie.Checked && !this.checkPodrkeslenie.Checked) {
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Italic);
            } if (this.checkPodrkeslenie.Checked && !this.checkPogrubienie.Checked && !this.checkPochylenie.Checked) {
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Underline);
            } if (this.checkPogrubienie.Checked && this.checkPochylenie.Checked && !this.checkPodrkeslenie.Checked) {
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Bold | FontStyle.Underline);
            } if (this.checkPochylenie.Checked && this.checkPodrkeslenie.Checked && !this.checkPogrubienie.Checked) { 
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Italic | FontStyle.Underline);
            } if (this.checkPogrubienie.Checked && this.checkPodrkeslenie.Checked && !this.checkPochylenie.Checked) { 
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Bold | FontStyle.Underline);
            } if (this.checkPogrubienie.Checked && this.checkPochylenie.Checked && this.checkPodrkeslenie.Checked) { 
                this.txtText.Font = new Font("Segoe UI", wielkosc, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
        }
    }
}
