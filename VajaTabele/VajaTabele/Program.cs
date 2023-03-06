using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VajaTabele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    char[,] c = new char[5, 5];
            //    Random r = new Random();
            //    for(int k = 0; k < c.GetLength(0); k++)
            //    {
            //        for(int j = 0; j < c.GetLength(1); j++)
            //        {
            //            c[k, j] = (char)(r.Next(26) + 'a');
            //        }
            //    }
            //    for (int k = 0; k < 5; k++)
            //    {
            //        for(int j = 0; j < 5; j++)
            //        {
            //            Console.Write(c[k, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    char min = 'z';
            //    for (int k = 0; k < 5; k++)
            //    {
            //        for(int j = 0; j < 5; j++)
            //        {
            //            if (c[k, j] < min)
            //                min = c[k, j];
            //        }
            //    }
            //    Console.WriteLine("Po abecedi je prva: "+min);
            //    Console.ReadLine();

            int[,] b = new int[10, 10];
            Random r = new Random();
            for(int k = 0; k < b.GetLength(0); k++)
            {
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    b[k,j]=(int) (r.Next(100));
                }
            }
            for(int k = 0; k < 10; k++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("{0,5:b}", b[k, j] + " ");
                }
                Console.WriteLine();
            }
            int max = 0;
            for(int k = 0; k < 10; k++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (b[k, j] > max)
                        max = b[k, j];
                }
            }
            int vsota = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
 
                    if (k == j) 
                        vsota = vsota + b[k, j];
                }
            }
            Console.WriteLine("Diagonala: ");
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (k == j)
                        Console.Write(b[k, j] + ",\n");
                }
            }
            Console.WriteLine("Največja številka: " + max);
            Console.WriteLine("Vsota: " + vsota);
            Console.ReadLine();
        }
    }
}
