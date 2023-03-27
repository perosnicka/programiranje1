using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    internal class Pravokotnik
    {
        public double a;
        public double b;

        public double A
        {
            get
            {
                if (a < 0)
                    return 0.0;
                else return a;
            }
            set { a = value; }

        }
        public double B
        {
            get
            {
                if (b < 0)
                    return 0.0;
                else return b;
            }
            set { b = value; }

        }

    }
}
