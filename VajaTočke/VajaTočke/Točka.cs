using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VajaTočke
{
    internal class Točka
    {
        double x;
        double y;
        double r;
        int kot;//kot v stopinjah

        public double X { get => x; set => x = value; }
        public void PretvoriVPolarne()
        {
            //x in y poznam, računam r in kot
            r = Math.Sqrt(x * x + y * y);
            kot =(int) (Math.Atan(y / x)*180/Math.PI);

        }
        public void PretvoriVKartezične()
        {
            //r in kot poznam, x in y računam
            x = Math.Round(r * Math.Cos(kot * Math.PI / 180),2);
            y = Math.Round(r * Math.Sin(kot * Math.PI / 180),2);
        }
        public Točka()
        {
            x = 0; y = 0;
            PretvoriVPolarne();
        }
        public Točka(double x1, double y1)
        {
            x = x1; y = y1;
            PretvoriVPolarne();
        }
        public Točka(int dx, int dy)
        {

        }
        public Točka(double r1, int kot1)
        {
            r = r1; kot = kot1;
            PretvoriVKartezične();
        }
        public void Izpis()
        {
            Console.WriteLine("*****TOČKA*****");
            Console.WriteLine("Kartezične: ("+x+","+y+")");
            Console.WriteLine("Polarne: (" + r + "," + kot + "°)");
        }
    }
}
