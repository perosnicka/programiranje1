using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaTočke
{
    internal class Točka
    {
        double x;
        double y;
        double r;
        int kot;//kot v stopinjah
        public void PretvoriVPolarne()
        {
            //x in y poznam, računam r in kot
            r = Math.Sqrt(x * x + y * y);
            kot =(int) (Math.Atan(y / x)*180/Math.PI);

        }
        public void PretvoriVKartezične()
        {
            //r in kot poznam, x in y računam
            x = r * Math.Cos(kot * Math.PI / 180);
            y = r * Math.Sin(kot * Math.PI / 180);
        }
    }
}
