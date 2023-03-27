using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaZaIzpit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metalec m = new Metalec(1, "Kozmus", "Primož","Ilirija", "Met kladiva");
            m.vnesiRezultat();
            m.Izpis();
            Console.WriteLine("Najdaljši met: "+m.NajboljsiMet());
            Console.ReadLine();
        }
    }
}
