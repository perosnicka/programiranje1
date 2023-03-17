using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNarisi_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Blue, 3);
            g.DrawEllipse(p,200,20,70,70);
            g.DrawEllipse(p, 220, 33, 10, 10);
            g.DrawEllipse(p, 240, 33, 10, 10);
            g.DrawArc(p, 210,35, 50, 35, 45, 115);
            g.DrawRectangle(p, 210, 95, 50, 100);
            g.DrawLine(p, 230, 196, 150, 250);
            g.DrawLine(p, 230, 200, 280, 250);

        }

        private void btnPobarvaj_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Orange);
            g.FillEllipse(b, 200, 20, 70, 70);
            b.Color=Color.Green;
            g.FillEllipse(b, 220, 33, 10, 10);
            g.FillEllipse(b, 240, 33, 10, 10);
            b.Color = Color.Red;
            g.FillPie(b, 210, 35, 50, 35, 45, 115);
            b.Color = Color.Maroon;
            g.FillRectangle(b,210, 95, 50, 100);
        }
    }
}
