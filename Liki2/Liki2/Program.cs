using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog k = new Krog(37, 45, 2.5f);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploscina());
            k.X = 2;
            k.Y = 2;
            k.Radij = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploscina());

            Valj v = new Valj(37, 45, 2.5f, 1f);
            Console.WriteLine("X koordinata = " + v.X +
            "\nY koordinata = " + v.Y +
            "\nRadij =" + v.Radij +
            "\nVišina =" + v.Visina);
            Console.WriteLine("Površina = " + v.Povrsina());
            Console.WriteLine("Volumen =" + v.Volumen());

            Console.ReadLine();
        }
    }
}
