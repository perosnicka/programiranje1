using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabeleVaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ocene = { 82, 90, 64, 80, 95, 75 };
            //Izračunaj povprečno vsoto
            int vsota = 0;
            for(int k = 0; k < ocene.Length; k++)
            {
                vsota += ocene[k];
            }
            Console.WriteLine("Povprečje je: " + ((double)vsota / ocene.Length));
            Console.ReadLine();*/

            int[] a = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            Console.WriteLine("Neurejena tabela");
            Izpis(a);
            Izbiranje(a);

            Console.ReadLine();
        }
        static void Izpis(int[] t)
        {
            for(int k = 0; k < t.Length; k++)
            {
                Console.Write(t[k]+"\t");
            }
            Console.ReadLine();
        }
        static void Izbiranje(int[] t)
        {
            //Uredi tabelo z imenom t po postopku izbiranja - selection sort
            for(int k = 0; k < t.Length - 1; k++)
            {
                //poišči minimun od k do konca tabele
                int min = t[k];
                int minIndeks = k;
                for(int j = k + 1; j < t.Length; j++)
                {
                    if (t[j] < min)
                    {
                        min = t[j];
                        minIndeks = j;
                    }
                }//konec iskanja min
                //zamenjaj element na mestu k z elementom na mestu minIndeks
                int c = t[k];
                t[k] = t[minIndeks];
                t[minIndeks] = c;
                Izpis(t);
            }//konec for
        }
    }
}
