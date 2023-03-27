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

namespace WpfApp6
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

        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IzracunPloscine();
        }

        private void sld2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IzracunPloscine();
        }

        public void IzracunPloscine()
        {
            double vrednost1 = double.Parse(txtSlider1.Text);
            double vrednost2 = double.Parse(txtSlider2.Text);

            rezultat.Text = (vrednost1 * vrednost2).ToString();

        }

    }
}
