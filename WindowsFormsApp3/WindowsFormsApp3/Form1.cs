using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radUSD.Checked = true;
        }

        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {
            txtVnos.Text = "";
            txtRezultat.Text = "";
            radUSD.Checked = true;
            lvlRezultat.Text = "";

        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            double vnos = double.Parse(txtVnos.Text);
            if (radUSD.Checked == true)
            {
                txtRezultat.Text= (vnos * 1.094).ToString();
                lvlRezultat.Text = "USD";
            }
            if (radCHF.Checked == true)
            {
                txtRezultat.Text = (vnos * 0.992).ToString();
                lvlRezultat.Text = "CHF";
            }
            if (radGBP.Checked == true)
            {
                txtRezultat.Text = (vnos * 0.88).ToString();
                lvlRezultat.Text = "GBP";
            }

        }
    }
}
