using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        private void btnDvojisko_Click(object sender, EventArgs e)
        {

            if(txtBox.Text == "")
            {
                MessageBox.Show("Emty");
            }
            else { 

            int stevilo = Int32.Parse(txtBox.Text);
            int ostanek = 0;
            string rezultat = "";

            while (stevilo > 0)
            {
                ostanek = stevilo % 2;
                stevilo = stevilo / 2;
                rezultat = ostanek.ToString() + rezultat;
            }
            txtBox.Text = rezultat;
        }
    }
    }
}


