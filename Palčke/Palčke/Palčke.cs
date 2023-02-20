using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palčke
{
    internal class Palčke
    {
        int StPalck;//število palčk na mizi
        int Igralec;//1 ali 2

        public int Igralec1 { get => Igralec;}
        public int StPalck1 { get => StPalck;}
        public Palčke()
        {
            Igralec = 1;
            StPalck = 11;
        }
        public Palčke(int st)
        {
            StPalck = st;
            Igralec = 1;
        }
        public Palčke(int st, int i)
        {
            StPalck = st;
            Igralec = i;
        }
        public void izpisStanja()
        {
            Console.WriteLine("Na mizi je: "+StPalck+" palčk.");
            Console.WriteLine("Na vrsti je: "+Igralec);
        }
        //vzemi n palčk iz mize in zamenjaj igralca
        public string izpisStanja1()
        {
            string r = "";
            r = r+"Na mizi je: " + StPalck + " palčk.";
            r = r+"\nNa vrsti je: " + Igralec;
            return r;
        }
        public void VzemiPalcke(int n)
        {
            if (n < 1 || n > 3)
            {
                Console.WriteLine("Ne slepari!");
                return;
            }
            StPalck = StPalck - n;
            Igralec = 3 - Igralec;
        }
        public bool JeKonec()
        {
            return StPalck <= 0;
        }
        public int DobiZmagovalca()
        {
            return Igralec;
        }
    }
}
