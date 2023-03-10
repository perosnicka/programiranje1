using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] zvoniki = { "Vipavski križ", "Renče", "Koper", "Nova Gorica" };
        private string[] metodeZvonenja ={"Plain Bob","Kent Treble Bob","Crawford Little Court","Old Oxford Deight"};
        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            txtIme.Text = "";
            txtPriimek.Text = "";
            cboZvonik.Items.Clear();
            foreach (string i in zvoniki)
                cboZvonik.Items.Add(i);
            cboZvonik.Text = cboZvonik.Items[0].ToString();
            lstMetode.Items.Clear();
            CheckBox metoda = null;
            foreach (string s in metodeZvonenja)
            {
                metoda = new CheckBox();
                metoda.Margin = new Thickness(0, 0, 0, 10);
                metoda.Content = s;
                lstMetode.Items.Add(metoda);
            }
            chkJeKapitan.IsChecked = false;
            radZačetnik.IsChecked = true;
            dtpČlanOd.Text = DateTime.Today.ToString();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                string imena = "Ime člana " +
                txtIme.Text + " " + txtPriimek.Text;
                foreach (CheckBox c in lstMetode.Items)
                    if (c.IsChecked.Value)
                        imena += "\n" + c.Content.ToString();
                MessageBox.Show(imena, "Podatki o članu", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        
    }
}
