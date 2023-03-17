using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color ozadje = Color.Wheat;
            Color ospredje = Color.FromArgb(200, 0, 0, 255);
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(ozadje);
            g.FillRectangle(br, 45, 20, 150, 120);
            Brush br1 = new SolidBrush(ospredje);
            g.FillRectangle(br1, 65, 35, 170, 130);
        }

        private void btnOzadje_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Color ozadje = Color.FromName(txtOzadje.Text);
            Brush br = new SolidBrush(ozadje);
            g.FillRectangle(br, 45, 20, 150, 120);

        }

        private void btnOspredje_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt.Text);
            int b = int.Parse(txt2.Text);
            int c = int.Parse(txt3.Text);
            int d = int.Parse(txt4.Text);

            if (a < 0 || a > 255)
                MessageBox.Show("Vrednost mora biti med 0 in 255");
            if (b < 0 || b > 255)
                MessageBox.Show("Vrednost mora biti med 0 in 255");
            if (c < 0 || c > 255)
                MessageBox.Show("Vrednost mora biti med 0 in 255");
            if (d < 0 || d > 255)
                MessageBox.Show("Vrednost mora biti med 0 in 255");

            Graphics g = CreateGraphics();
            Color ospredje = Color.FromArgb(a, b, c, d);
            Brush br = new SolidBrush(ospredje);
            g.FillRectangle(br, 65, 35, 170, 130);
        }
    }
}
