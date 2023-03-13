using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Liki2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textStranica.Text);
            int obseg = 4 * a;
            int ploscina = a * a;
            textObseg.Text = obseg + "";
            textPloscina.Text = ploscina + "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textPolmer.Text);
            double pi = Math.PI;
            double obsegkr = 2 * pi * b;
            double ploscinakr = pi * b * b;
            textObsegK.Text = obsegkr + "";
            textPloscinaK.Text = ploscinakr + "";
        }
    }
}
