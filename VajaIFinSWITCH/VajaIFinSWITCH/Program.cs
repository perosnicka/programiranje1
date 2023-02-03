using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIFinSWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Prvo število: ");
            String a = Console.ReadLine();
            Console.WriteLine("Drugo število: ");
            String b = Console.ReadLine();
            Console.WriteLine("Tretje število: ");
            String c = Console.ReadLine();
            int trikotnika = int.Parse(a);
            int trikotnikb = int.Parse(b);
            int trikotnikc = int.Parse(c);
            if (trikotnika + trikotnikb > trikotnikc && trikotnika + trikotnikc > trikotnikb && trikotnikb + trikotnikc > trikotnika) 
            {
                Console.WriteLine("So stranice trikotnika");
            }
            else
            {
                Console.WriteLine("Niso stranice trikotnika");
            }
            */
            
            Console.WriteLine("Vnesite trimestno število: ");
            String a = Console.ReadLine();
            int stevilo = int.Parse(a);
            int b = stevilo % 10;
            int c = b % 10;
            int d = c % 10;
            if (b % 2 == 0 && c % 2 == 0 && d % 2 == 0)
            {
                Console.WriteLine("So soda števila");
            }
            else if (b % 2 != 0 && c % 2 != 0 && d % 2 != 0)
            {
                Console.WriteLine("števila so liha");
            }
            else
            {
                Console.WriteLine("števila so liha in soda");
            }
        }
    }
}