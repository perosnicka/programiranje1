using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Atlet
    {
        protected int startnaŠtevilka;
        protected string priimek;
        protected string ime;
        protected string klub;
        public Atlet(int s, string p, string i, string k)
        {
            startnaŠtevilka = s; priimek = p; ime = i; klub = k;
        }
        public abstract void vnesiRezultat();
        public void Izpis()
        {
            Console.WriteLine("Startna številka " + startnaŠtevilka +
            "\nAtlet " + ime + " " + priimek +
            "\nKlub " + klub + "\n");
        }
    }
    class Metalec : Atlet
    {
        protected string imeDiscipline;
        protected double[] meti = new double[6];

        public override void vnesiRezultat()
        {
            for (int i = 0; i < meti.Length; i++)
            {
                Console.Write("Vnesi dolžino " + (i + 1) + ". meti: ");
                meti[i] = double.Parse(Console.ReadLine());
            }
        }

        public Metalec(int s, string p, string i, string k, string d)
            : base(s,p,i,k)
        {
            imeDiscipline = d;
        }
           
        public new void Izpis()
        {
            base.Izpis();
            for(int i = 0; i < meti.Length; i++)
            {
                Console.WriteLine("{0:f2}",meti[i]);
            }
        }

        public double NajboljsiMet()
        {
            double naj = 0;
            for (int i = 0; i < meti.Length; i++)
            {
                if (meti[i] > naj)
                    naj = meti[i];
            }
            return naj;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Metalec m = new Metalec(1, "Kozmus", "Primož", "Ilirija", "met kladiva");
            m.vnesiRezultat();
            Console.WriteLine();
            m.Izpis();
            Console.Write("Najboljši rezultat: {0:f2}" + m.NajboljsiMet());
            Console.ReadLine();
        }
    }
}
