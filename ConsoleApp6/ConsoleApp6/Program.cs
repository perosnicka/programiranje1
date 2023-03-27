using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            Prevoznik prevoz = new Prevoznik();
            prevoz.Sifra = "755";
            prevoz.Ime = "Janez Kranjski";
            prevoz.Licenca = "CLD";

            prevoz.SpremeniUre(7);
            prevoz.Izpis();

            prevoz.SpremeniUre(-10);
            prevoz.Izpis();
            Console.ReadLine();
        }
    }
}
