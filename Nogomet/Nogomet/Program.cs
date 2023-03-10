using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogomet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvropskoPrvenstvo n = new EvropskoPrvenstvo();
            n.IzpisiTurnir();
            Console.ReadLine();
        }
    }
}
