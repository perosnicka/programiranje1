using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radInformatika_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent Informatike";
            lblVmesna.Visible = true;
            lblKOncna.Visible = true;
            lblUstna.Visible = true;
            lblSeminar.Visible = true;

            txtVmesna.Text = " ";
            txtUstna.Visible = true;
            txtUstna.Text = " ";
            txtSeminar.Visible = true;
            txtSeminar.Text = " ";
            txtKoncna.Text = " ";
            lblOcena.Text = " ";
            lblPovp.Text = " ";

        }

        private void radMehatronika_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent Mehatronike";
            lblVmesna.Visible = true;
            lblKOncna.Visible = true;
            lblUstna.Visible = false;
            lblSeminar.Visible = false;

            txtVmesna.Text = " ";
            txtUstna.Visible = false;
            txtSeminar.Visible = false;
            txtKoncna.Text = " ";
        }

        private void radUPK_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent UPK";
            lblVmesna.Visible = true;
            lblKOncna.Visible = true;
            lblUstna.Visible = false;
            lblSeminar.Visible = true;

            txtVmesna.Text = "";
            txtUstna.Visible = false;
            txtSeminar.Visible = true;
            txtSeminar.Text = "";
            txtKoncna.Text = "";
        }

        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            grpIme.Text = "Študent Informatike";
            lblVmesna.Visible = true;
            lblKOncna.Visible = true;
            lblUstna.Visible = true;
            lblSeminar.Visible = true;
            txtUstna.Visible = true;

            radInformatika.Checked = true;

            txtVmesna.Text = "";
            txtUstna.Text = "";
            txtSeminar.Text = "";
            txtKoncna.Text = "";

            lblPovp.Text = " ";
            lblOcena.Text = " ";

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (radInformatika.Checked == true)
            {
                try
                {
                    StudentINF x = new StudentINF();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Seminar = int.Parse(txtSeminar.Text);
                    x.Ustna = int.Parse(txtUstna.Text);
                    x.Racunaj();
                    lblPovp.Text = "Povprečje točk je: " + x.Povp;
                    lblOcena.Text = "KONČNA OCENA: " + x.Vmesna;
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (radMehatronika.Checked == true)
            {
                try
                {
                    StudentMehatronika x = new StudentMehatronika();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Racunaj();
                    lblPovp.Text = "Povprečje točk je: " + x.Povp;
                    lblOcena.Text = "KONČNA OCENA: " + x.Vmesna;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }

            if (radUPK.Checked == true)
            {
                try
                {
                    StudentUPK x = new StudentUPK();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Seminar = int.Parse(txtSeminar.Text);
                    x.Racunaj();
                    lblPovp.Text = "Povprečje točk je: " + x.Povp;
                    lblOcena.Text = "KONČNA OCENA: " + x.Vmesna;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }


        }



    }
}
