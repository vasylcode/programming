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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for SEdit.xaml
    /// </summary>
    public partial class SEdit : Window {
        public Student student;
        public SEdit(Student student = null) {
            InitializeComponent();
            if (student != null) {
                txtImie.Text = student.imie;
                txtNazwisko.Text = student.nazwisko;
                txtNr.Text = student.NrIndeksu.ToString();
                txtWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        private void bOK(object sender, RoutedEventArgs e) {
            if (!Regex.IsMatch(txtImie.Text, @"^\p{Lu}\p{Ll}{1, 12}$") ||
               !Regex.IsMatch(txtNazwisko.Text, @"^\p{Lu}\p{Ll}{1, 12}$") ||
               !Regex.IsMatch(txtWydzial.Text, @"^\p{Lu}\p{Ll}{1, 12}$") ||
               !Regex.IsMatch(txtNr.Text, @"^[0-9]{4, 10}$"))
            {
                MessageBox.Show("Podano błędne dane.");
                return;
            }

            student.imie = txtImie.Text;
            student.nazwisko = txtNazwisko.Text;
            student.NrIndeksu = int.Parse(txtNr.Text);
            student.wydzial = txtWydzial.Text;

            this.DialogResult = true;
        }
    }
}
