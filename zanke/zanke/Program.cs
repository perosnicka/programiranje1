using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int min = 10000;
            for (int k = 0; k < 10; k++) //10x ponovi
            {
                Console.WriteLine(k+". vnesi nasledje število: ");
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine("najmanjše je: "+min);
            Console.ReadLine();
            */

            /*
            int vsota = 0;
            Random r = new Random();
            for (int k = 0; k < 100; k++)
            {
                int x = r.Next(100);
                vsota = vsota + x;
            }
            Console.WriteLine("vsota: " + vsota);
            */

            /*
            int vsota = 0;
            Random r = new Random();
            for (int k = 0; k < 1000; k++)
            {
                int x = r.Next(1000);
                vsota = vsota + x;
            }
            Console.WriteLine("Vrednost: " + vsota / 1000);
            */

            float vsotaZneskov = 0;
            float vsotaObresti = 0;
            Random r = new Random();
            for(int k = 0; k < 100000; k++)
            {
                float znesek = r.Next(100000);
                vsotaZneskov = vsotaZneskov + znesek;
                float obresti = znesek * 0.023f;
                vsotaObresti = vsotaObresti + obresti;
            }
            Console.WriteLine("Vsota zneskov * 0.023 {0,15:n2}", vsotaZneskov * 0.023f);
            Console.WriteLine("Vsota obresti         {0,15:n2}", vsotaObresti);
            Console.ReadLine();

            /*
            int min = 10000;
            int k = 0;
            while (k < 10) //10x ponovi
            {
                Console.WriteLine(k + ". vnesi nasledje število: ");
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                {
                    min = x;
                }
                k++;
            }
            Console.WriteLine("najmanjše je: " + min);
            Console.ReadLine();
            */

            /*
            int min = 10000;
            int k = 0;
            do
            {
                Console.WriteLine(k + ". vnesi nasledje število: ");
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                {
                    min = x;
                }
                k++;
            }
            while (k < 10); //10x ponovi

            Console.WriteLine("najmanjše je: " + min);
            Console.ReadLine();
            */
        }
    }
}
