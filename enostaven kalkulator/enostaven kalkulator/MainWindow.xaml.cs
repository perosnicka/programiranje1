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

namespace enostaven_kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Prvo(object sender, TextChangedEventArgs e)
        {

        }

        private void Drugo(object sender, TextChangedEventArgs e)
        {

        }

        private void Rezultat(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Seštej_Click(object sender, RoutedEventArgs e)
        {
            double r=0;
            int a = int.Parse(prvo.Text);
            int b = int.Parse(drugo.Text);
            double rez = a + b;
            rezultat.Text = rez + "";
        }
    }
}
