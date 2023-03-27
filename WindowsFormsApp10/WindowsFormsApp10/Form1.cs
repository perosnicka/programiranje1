using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radUSD.Checked = true;
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double vrednost = double.Parse(txtVnos.Text);

            if (radUSD.Checked == true)
            {
                vrednost = vrednost * 1.2820;
                txtRezultat.Text = vrednost.ToString();
                lblRezultat.Text = "USD";
            }
            if (radJPY.Checked == true)
            {
                vrednost = vrednost * 159.1828;
                txtRezultat.Text = vrednost.ToString();
                lblRezultat.Text = "JPY";
            }
            if (radGBP.Checked == true)
            {
                vrednost = vrednost * 0.6644;
                txtRezultat.Text = vrednost.ToString();
                lblRezultat.Text = "GBP";
            }

        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = " ";
            txtVnos.Text = " ";
            lblRezultat.Text = " ";
            radUSD.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
