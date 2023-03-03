using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal class Igrace : AbstractProduct
    {
        public Igrace(int i , string im, double p)
        {
            ID = i;
            Ime = im;
            Cena = p;
        }
        public override string GetDescription()
        {
            return "To je eden od primerov igrač: ";        
        }

        public override double GetDiscountPrice()
        {
            return Cena * 0.9;
        }
    }
}
