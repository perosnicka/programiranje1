using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izpit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radJPY_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "JPY";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {

        }

        private void radUSD_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "USD";
        }

        private void lblRezultat_Click(object sender, EventArgs e)
        {

        }

        private void textVnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void radGBP_CheckedChanged(object sender, EventArgs e)
        {
            lblRezultat.Text = "GBP";
        }

        private void brnIzracun_Click(object sender, EventArgs e)
        {
            double USD = 1.2810;
            double JPY = 159.1828;
            double GBP = 0.6644;
            int a = int.Parse(textVnos.Text);
            double USD1 = a * USD;
            textRezultat.Text = USD1 + "";
            double JPY1 = a * JPY;
            textRezultat.Text = JPY1 + "";
            if (radGBP = true) ;
            double GBP1 = a * GBP;
            textRezultat.Text = GBP1 + "";
        }
    }
}
