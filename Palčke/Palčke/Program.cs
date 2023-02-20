using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palčke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palčke p = new Palčke(23, 2);
            while (!p.JeKonec())
            {
                Console.WriteLine(p.izpisStanja1());
                Console.WriteLine("Koliko palčk vzameš? ");
                int x = int.Parse(Console.ReadLine());
                p.VzemiPalcke(x);
            }
            Console.WriteLine("Zmagal je: "+p.DobiZmagovalca());
            Console.ReadLine();
        }
    }
}
