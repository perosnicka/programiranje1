using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    abstract class Student
    {
        protected int vmesna;
        protected int koncna;
        protected int seminar;
        protected int ustna;

        protected double povp;
        protected int ocena;


        public Student()
        {
      
        }

        public int Vmesna
        {
            get { return vmesna; }
            set
            {
                if (value < 0 | value > 100)
                {
                    MessageBox.Show("Napaka. Program se končuje!");
                    Environment.Exit(0);
                }
                else
                    vmesna = value;
            }

        }

        public int Koncna
        {
            get { return koncna; }
            set
            {
                if (value < 0 | value > 100)
                {
                    MessageBox.Show("Napaka. Program se končuje!");
                    Environment.Exit(0);
                }
                else
                    koncna = value;
            }

        }

        public int Seminar
        {
            get { return seminar; }
            set
            {
                if (value < 0 | value > 100)
                {
                    MessageBox.Show("Napaka. Program se končuje!");
                    Environment.Exit(0);
                }
                else
                    seminar = value;
            }

        }

        public int Ustna
        {
            get { return ustna; }
            set
            {
                if (value < 0 | value > 100)
                {
                    MessageBox.Show("Napaka. Program se končuje!");
                    Environment.Exit(0);
                }
                else
                    ustna = value;
            }

        }

        public double Povp
        {
            get { return ocena; }
        }

        public abstract void Racunaj();

    }
}
