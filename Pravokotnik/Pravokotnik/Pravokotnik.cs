using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    internal class Pravokotnik
    {
        int dolzina;
        int sirina;

        public int Sirina { get => sirina;}
        public int Dolzina { get => dolzina;}

        public Pravokotnik(int d, int s)
        {
            dolzina = d;
            sirina = s;
        }
        public int GetArea()
        {
            return dolzina * sirina;
        }
        public int GetPerimeter()
        {
            return 2 * dolzina + 2 * sirina;
        }
        public bool IsSquare ()
        {
            if (dolzina == sirina)
            {
                return true;
            }
                return false;

        }
    }
}
