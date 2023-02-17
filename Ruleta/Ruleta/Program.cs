using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi začetni denarni vložek: ");
            int stanje = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi začetno višino stave: ");
            int stava = int.Parse(Console.ReadLine());
            Random kroglica = new Random();
            int zacStanje = stanje;
            int zacStava = stava;
            int min = 1000;
            int max = 0;
            String barva = "";
            for (int m = 1;  m <= 10; m++)
            {
                int a = kroglica.Next(0, 36);
                if (a % 2 == 0 && a != 0)
                {
                    stanje = stanje + stava;
                    stava = zacStava;
                    barva = "rdeča";
                }
                else
                {
                    stanje = stanje - stava;
                    stava = stava * 2;
                    barva = "črna";
                }
                if(stanje < min)
                {
                    min = stanje;
                }
                if ( stanje > max)
                {
                    max = stanje;
                }
            Console.WriteLine("Met: "+m+" Barva"+barva+" Stanje: "+zacStanje);
            }
            int razlika = stanje - zacStanje;
            Console.WriteLine("Število metov: " + 10);
            Console.WriteLine("Začetno stanje: " + zacStanje);
            Console.WriteLine("Trenutno stanje: " + stanje);
            Console.WriteLine("Najvišje stanje: " + max);
            Console.WriteLine("Najnižje stanje: " + min);
            Console.WriteLine("Dobiček/izguba: " + razlika);
            Console.ReadLine();

        }
    }
}
