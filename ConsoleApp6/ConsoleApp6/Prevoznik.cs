using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Prevoznik
    {
        private string sifra;
        private string ime;
        private int stUr;
        private string licenca;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Licenca
        {
            get { return licenca; }
            set { licenca = value; }
        }

        public int StUr
        {
            get { return stUr; }
        }

        public Prevoznik()
        {
            stUr = 0;
        }

        public void SpremeniUre(int ur)
        {
            if (ur < 0)
            {
                Console.WriteLine("Napaka");
            }
            else
            {
                stUr += ur;
            }
        }

        public void Izpis()
        {
            Console.WriteLine("Šifra: {0}", sifra);
            Console.WriteLine("Ime: {0}", ime);
            Console.WriteLine("Število ur: {0}", stUr);
            Console.WriteLine("Licenca: {0}", licenca);

        }

    }
}
