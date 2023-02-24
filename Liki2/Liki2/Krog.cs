using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki2
{
    internal class Krog
    {
        int x;
        int y;
        double radij;

        public Krog(int xK, int yK, double rK)
        {
            x = xK;
            y = yK;
            radij = rK;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double Radij { get => radij; set => radij = value; }
        public double Premer()
        {
            return Math.Abs(2 * radij);
        }
        public double Ploscina()
        {
            return Math.PI*radij*radij ;
        }
    } 
}
