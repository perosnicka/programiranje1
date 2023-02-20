using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi
{
    internal class Oseba
    {
        int starost;
        string ime;

        public int Starost { get => starost;}
        public string Ime { get => ime;}

        public Oseba(String i , int s)
        {
            ime = i; starost = s;
        }

        public int GetAgeInMonths()
        {
            return 12 * starost;
        }

        public bool IsAdult()
        {
            if (starost < 18)
                return false;
            else
                return true;
        }
        public bool IsEqual(Oseba x)
        {
            if (ime == x.ime && starost == x.starost)
                return true;
            else
                return false;
        }
    }
}
