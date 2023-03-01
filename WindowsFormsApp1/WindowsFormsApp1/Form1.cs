using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBarva_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = colorDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                txtVnos.ForeColor = colorDialog1.Color;
            }
            else
                MessageBox.Show("Barve nisi zamenjel");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = fontDialog1.ShowDialog();
            if(a== DialogResult.OK)
            {
                txtVnos.Font = fontDialog1.Font;
            }
            else
                MessageBox.Show("Barve nisi zamenjel");
        }
    }
}
