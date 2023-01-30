using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random k = new Random();
            int x = k.Next(4);
            karta karta = (karta)x;
            Console.WriteLine("karta: "+karta);

            


            Random v = new Random();
            int y= v.Next(13);
            Vrednost vrednost = (Vrednost)y;
            Console.WriteLine("vrednost: " + vrednost);

            Console.ReadLine();
        }
    }
}
