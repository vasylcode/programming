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

namespace Lab3Zadanie2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        double coef, val, result;

        private void btnWylicz_Click(object sender, RoutedEventArgs e) {
            try {
                if ((listbox.SelectedItem as ListBoxItem).Content.ToString() == "Rzeszów") {
                    coef = 0.6;
                } else if ((listbox.SelectedItem as ListBoxItem).Content.ToString() == "Warszawa") {
                    coef = 0.8;
                } else {
                    coef = 0.5;
                }

                if (rdrNormalny.IsChecked == true) {
                    val = 6;
                } else if (rdrUstawowy.IsChecked == true) {
                    val = 3;
                } else if (rdrSamorzad.IsChecked == true) {
                    val = 4;
                }
                result = val * coef;
                txtResult.Text = Math.Round(result, 2).ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK);
            }
        }
    }
}
