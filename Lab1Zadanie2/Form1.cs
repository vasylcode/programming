using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Zadanie2
{
    public partial class Kalkulator : Form {
        double first;
        string operation;
        public Kalkulator() {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + "0";
        }


        private void btnC_Click(object sender, EventArgs e) {
            textBoxMain.Text = "";
            operation = "";
        }

        private void btnCom_Click(object sender, EventArgs e) {
            textBoxMain.Text = textBoxMain.Text + ",";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            first = Convert.ToDouble(textBoxMain.Text);
            textBoxMain.Text = "";
            operation = "+";
        }

        private void btnMult_Click(object sender, EventArgs e) {
            first = Convert.ToDouble(textBoxMain.Text);
            textBoxMain.Text = "";
            operation = "*";
        }

        private void btnMinus_Click(object sender, EventArgs e) {
            first = Convert.ToDouble(textBoxMain.Text);
            textBoxMain.Text = "";
            operation = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            first = Convert.ToDouble(textBoxMain.Text);
            textBoxMain.Text = "";
            operation = "/";
        }

        private void btnEq_Click(object sender, EventArgs e) {
            double second;
            double wynik;

            second = Convert.ToDouble(textBoxMain.Text);

            if (operation == "+") {
                wynik = (first + second);
                textBoxMain.Text = Convert.ToString(wynik);
                first = wynik;
            }

            if (operation == "*") {
                wynik = (first * second);
                textBoxMain.Text = Convert.ToString(wynik);
                first = wynik;
            }

            if (operation == "-") {
                wynik = (first - second);
                textBoxMain.Text = Convert.ToString(wynik);
                first = wynik;
            }

            if (operation == "/") {
                if (second != 0) {
                    wynik = (first / second);
                    textBoxMain.Text = Convert.ToString(wynik);
                    first = wynik;
                } else {
                    textBoxMain.Text = "Nie można dzielić przez zero";
                }
            }
        }
    }
}
