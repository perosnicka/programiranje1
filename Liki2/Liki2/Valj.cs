using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Liki2
{
    internal class Valj:Krog
    {
        double visina;

        public Valj(int xV, int yV, double rV, double vV):base(xV, yV, rV)
        {
            visina = vV;   
        }

        public double Visina { get => visina; set => visina = value; }

        public double Povrsina()
        {
            return base.Ploscina() * 2 * Math.PI * Radij;
        }
        public double Volumen()
        {
            return Math.PI * Radij * Radij * visina;
        }
    }
    
}
