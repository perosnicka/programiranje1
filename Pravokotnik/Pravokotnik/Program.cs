using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik a = new Pravokotnik(6, 7);
            Console.WriteLine(" Površina "+a.GetArea());
            Console.WriteLine(" Obseg "+a.GetPerimeter());
            Console.WriteLine(" Kvadrat "+a.IsSquare());
        }
    }
}
