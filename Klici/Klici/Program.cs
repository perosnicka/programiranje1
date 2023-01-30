using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip klica 1-mobilno, 2-stacionarno: ");
            string tip = Console.ReadLine();
            int tipKlica = int.Parse(tip);
            TipKlica klic = (TipKlica)tipKlica;
            //znesek
            Console.WriteLine("vnesi število minut: ");
            int minute = int.Parse(Console.ReadLine());
            double znesek = 0;
            if (klic == TipKlica.KlicVMobilno)
            {
                znesek = minute * 0.03;
            }
            else
            {
                znesek = minute * 0.02;
            }
            Console.WriteLine("dolguješ: "+znesek);
            Console.ReadLine();
        }
    }
}
