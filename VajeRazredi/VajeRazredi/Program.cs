using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oseba a=new Oseba("Miha", 19);
            Oseba b = new Oseba("Marija", 16);
            Console.WriteLine(a.Ime+" je polnoleten? "+a.IsAdult());
            Console.WriteLine(a.Ime+" je ista oseba kot "+b.Ime+" ? "+a.IsEqual(b));
            Console.ReadLine();
        }
    }
}
