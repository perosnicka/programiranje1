using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int st = 0;
            for (int k = (int)'A'; k <= (int)'Z'; k++)
            {
                Console.Write((char)k);
                st++;
                if(st == 10)
                {
                    Console.WriteLine("\n");
                    st = 0;
                }

            }
            
        }
    }
}
