using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet
{
    internal class EvropskoPrvenstvo
    {
        Ekipa[] liga = new Ekipa[10];
        int[,] pari = new int[10, 10];

        public EvropskoPrvenstvo()
        {
            liga[0] = new Ekipa("Slovenija");
            liga[1] = new Ekipa("Islandija");
            liga[2] = new Ekipa("Poljska  ");
            liga[3] = new Ekipa("Švica    ");
            liga[4] = new Ekipa("Srbija   ");
            liga[5] = new Ekipa("Nemčija  ");
            liga[6] = new Ekipa("Španija  ");
            liga[7] = new Ekipa("grčija   ");
            liga[8] = new Ekipa("Italija  ");
            liga[9] = new Ekipa("Hrvaška  ");

            IzdelajTurnir();
        }
        public void IzpisiTurnir()
        {
            for(int kolo = 1; kolo <= 9; kolo++)
            {
                Console.WriteLine(kolo + ". kolo");
                for(int j = 0; j < 10; j++)
                {
                    for(int z = 0; z < 10; z++)
                    {
                        if (pari[j, z] == kolo)
                        {
                            Ekipa prva = liga[j];
                            Ekipa druga = liga[z];
                            Console.WriteLine(prva.Ime + " : " + druga.Ime);

                        }
                    }
                }
            }
        }

        int x = 0;
        int y = 1;
        int[] zgoraj = { 2, 3, 4, 5 };
        int[] spodaj = { 9, 8, 7, 6 };
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            pari[zgoraj[0], spodaj[0]] = kolo;
            pari[zgoraj[1], spodaj[1]] = kolo;
            pari[zgoraj[2], spodaj[2]] = kolo;
            pari[zgoraj[3], spodaj[3]] = kolo;
            int temp = y;
            y = spodaj[0];
            spodaj[0] = spodaj[1];
            spodaj[1] = spodaj[2];
            spodaj[2] = spodaj[3];
            spodaj[3] = zgoraj[3];
            zgoraj[3] = zgoraj[2];
            zgoraj[2] = zgoraj[1];
            zgoraj[1] = zgoraj[0];
            zgoraj[0] = temp;

        }
        public void IzdelajTurnir()
        {
            for(int k = 1; k <= 9; k++)
            {
                NapolniPare(k);
            }
        }
    }
}