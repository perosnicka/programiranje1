using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postevanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            Console.WriteLine("vpiši število poštevanke, ki bi se jo rad naučil (1-10): ");
            int x = int.Parse(Console.ReadLine());
            Random y = new Random();
            while(p < 5)
            {
            int k = y.Next(1, 10);
            Console.WriteLine( x + "*" + k);
            Console.WriteLine("Vpiši rezultat: ");
            int a = int.Parse(Console.ReadLine());
            if (a == x * k)
            {
                Console.WriteLine("Pravilni odgovor");
            }else
            {
                Console.WriteLine("Nepravilni odgovor");
            }
                p++;
            }
        }
    }
}
