using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal abstract class AbstractProduct : IProduct
    {
        protected int ID;
        protected string Ime;
        protected double Cena;
        public int GetID()
        {
            return ID;
        }

        public string GetIme()
        {
            return Ime;
        }

        public double GetCena()
        {
            return Cena;        
        }
          public abstract string GetDescription();
          public abstract double GetDiscountPrice();
        public string GetCategory()
        {
            //Če bo izvid razred igrača, vrni "igrača"
            if (this is Igrace)
                return "Kategorija = igrača ";
            if (this is Knjiga)
                return "Kategorija = knjiga";
            return "Neznana kategorija";
        }
    }

}
