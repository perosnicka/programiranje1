﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaTočke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Točka t1 = new Točka(1.0, 1.0);
            t1.Izpis();
            Točka t2 = new Točka(1.0, 180);
            t2.Izpis();
            Console.ReadLine();
        }
    }
}
