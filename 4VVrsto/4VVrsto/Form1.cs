using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4VVrsto
{
    public partial class Form1 : Form
    {
        int[,] stanje =
        {
            {0,0,0,0,0,0,0 },
            {0,0,0,1,0,0,0 },
            {0,0,1,2,0,0,0 },
            {0,1,2,1,2,0,0 },
            {1,1,2,2,1,2,0 }
        };
        public Form1()
        {
            InitializeComponent();
        }
         
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            NarišiVodoravne(g);
            NarišiNavpične(g);
            NarišiKrogec(g);
        }

        private void NarišiVodoravne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            int y = 0;
            for (int i = 0; i <= 5; i++)
            {
                g.DrawLine(p, 0, y, 7 * 100, y);
                y += 100;
            }
        }

        private void NarišiNavpične(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            int x = 0;
            for (int i = 0; i <= 7; i++)
            {
                g.DrawLine(p, x, 0, x, 5 * 100);
                x += 100;
            }
        }

        private void NarišiKrogec(Graphics g)
        {
            int y = 0;
            for(int i = 0; i < 5; i++)
            {
                int x = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (stanje[i, j] == 1)
                    {
                        Brush br = new SolidBrush(Color.Red);
                        g.FillEllipse(br, x, y, 100, 100);
                    }
                    if (stanje[i, j] == 2)
                    {
                        Brush br = new SolidBrush(Color.Green);
                        g.FillEllipse(br, x, y, 100, 100);
                    }
                    x += 100;
                }
                y += 100;
            }
        }
    }
}
