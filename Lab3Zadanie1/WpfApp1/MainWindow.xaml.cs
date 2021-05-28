using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        double a, b;
        string result;

        private void btnRoznica_Click(object sender, RoutedEventArgs e) {
            a = double.Parse(txtboxA.Text);
            b = double.Parse(txtboxB.Text);
            result = (a - b).ToString();
            txtboxWynik.Text = "Różnica: " + a + " - " + b + " = " + result;
        }

        private void btnOczyn_Click(object sender, RoutedEventArgs e) {
            try { 
                a = double.Parse(txtboxA.Text);
                b = double.Parse(txtboxB.Text);
                if (b == 0) {
                    throw new Exception("Nie można dzielić przez 0!");
                }
                result = (a / b).ToString();
                txtboxWynik.Text = "Iloczyn: " + a + " / " + b + " = " + result;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK);
            }
        }

        private void btnOraz_Click(object sender, RoutedEventArgs e) {
            a = double.Parse(txtboxA.Text);
            b = double.Parse(txtboxB.Text);
            result = (a * b).ToString();
            txtboxWynik.Text = "Iloraz: " + a + " * " + b + " = " + result;
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e) {
            a = double.Parse(txtboxA.Text);
            b = double.Parse(txtboxB.Text);
            result = (a + b).ToString();
            txtboxWynik.Text = "Suma: " + a + " + " + b + " = " + result;
        }
    }
}
