using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Bitmap original = new Bitmap("D:\\logo.jpg");
        public Form1()
        {
            InitializeComponent();
            NastaviDrsnike();
        }

        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult a; //Kateri gumb je izbral uporabnik?
            a = dlg.ShowDialog();
            if (a != DialogResult.OK)
                return; // če uporanik ni kliknil OK, končamo
            string imeDatoteke = dlg.FileName;
            original = new Bitmap(imeDatoteke);
            pictureBox.Image = original;

        }

            private void NastaviDrsnike()
            {
            Bitmap original = new Bitmap("D:\\logo.jpg");
            if (pictureBox.Width > original.Width - vScrollBar1.Width)
                    hScrollBar1.Visible = false;
                else
                {
                    hScrollBar1.Visible = true;
                    hScrollBar1.Maximum = original.Width - pictureBox.Width;
                }
                if (pictureBox.Height > original.Height - hScrollBar1.Height)
                    vScrollBar1.Visible = false;
                else
                {
                    vScrollBar1.Visible = true;
                    vScrollBar1.Maximum = original.Height - pictureBox.Height;
                }
            }

            private void PosodobiSliko()
            {
                Graphics g = pictureBox.CreateGraphics();
                g.DrawImage(pictureBox.Image, new Rectangle(0, 0,
                pictureBox.Width, pictureBox.Height),
               new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                pictureBox.Width, pictureBox.Height),
                GraphicsUnit.Pixel);
                NastaviDrsnike();
                pictureBox.Update();
            }

        private void SpremeniVelikost()
        {
            pictureBox.Width = this.Width - vScrollBar1.Width - 15;
            pictureBox.Height = this.Height - hScrollBar1.Height - 60;
            NastaviDrsnike();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        
        private void shraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg1 = new SaveFileDialog();
            dlg1.Filter = "Slike (*.jpg)|*.jpg|Vse datoteke (*.*)|*.*";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            string strImeDatoteke = dlg.FileName;
            original.Save(strImeDatoteke, System.Drawing.Imaging.ImageFormat.Jpeg);
            
        }
       
        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //potrditev od uporabnika ??
        }
        
        private void zavrtiza180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap("D:\\logo.jpg");
            PosodobiSliko();
            original.RotateFlip(RotateFlipType.Rotate180FlipNone);
            PosodobiSliko();
        }
        
        private void zavrtiza270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap("D:\\logo.jpg");
            PosodobiSliko();
            original.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PosodobiSliko();

        }
        
        private void svetlejšeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosodobiSliko();
            SvFilter(1.1);
            PosodobiSliko();
        }
        private void SvFilter(double mag)
        {
            Bitmap original = new Bitmap("D:\\logo.jpg");
            Color pixel;
            int r, g, b;
            for (int y = 0; y < original.Height; y++) // Po vsej višini slike
                for (int x = 0; x < original.Width; x++) //po širini
                {
                    pixel = original.GetPixel(x, y); //barva pixla
                    r = (int)((double)pixel.R * 1.1); //posvetli rdečo
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    g = (int)((double)pixel.G * 1.1);//posvetli zelo
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    b = (int)((double)pixel.B * 1.1);//posvetli modro
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    original.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            PosodobiSliko();
        }
        private void temnejšeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosodobiSliko();
            SvFilter(0.9);
            PosodobiSliko();
        }
        
        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color piksel;

            for (int y = 0; y < original.Height; y++)
                for (int x = 0; x < original.Width; x++)
                {
                    piksel = original.GetPixel(x, y);
                    original.SetPixel(x, y, Color.FromArgb(255 - piksel.R, 255 -
                    piksel.G, 255 - piksel.B));
                }
            PosodobiSliko();
        }
        
        private void natisniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            pd.Print();
        }
        private void pd_PrintPage(object
        sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(pictureBox.Image,
            new Rectangle(0, 0, pictureBox.Width, pictureBox.Height),
            new Rectangle(0, 0, pictureBox.Width, pictureBox.Height),
            GraphicsUnit.Pixel);
        }
       
        private void zrcalinavpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color b;
            for (int y = 0; y < original.Height; y++)
            {

                for (int x = 0; x < original.Width / 2; x++)
                {
                    b = original.GetPixel(x, y);
                    original.SetPixel(original.Width - x - 1, y, b);
                }
            }
            PosodobiSliko();
        }

    }
}
