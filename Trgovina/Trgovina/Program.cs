using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Igrace a = new Igrace(1, "Žoga", 5.6);
            Console.WriteLine(a.GetIme()+" "+a.GetCategory());
            Console.WriteLine(a.GetDescription());
            Console.WriteLine(a.GetCena()+" "+a.GetDiscountPrice());

            Knjiga b = new Knjiga(2, "Millenium", 25.4);
            Console.WriteLine(b.GetIme() + " " + b.GetCategory());
            Console.WriteLine(b.GetDescription());
            Console.WriteLine(b.GetCena() + " " + b.GetDiscountPrice());

            Console.ReadLine();
        }
    }
}
