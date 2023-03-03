using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class RacunCD
    {
        protected const double enDan = 1.0;
        protected const double dvaDan = 2.5;
        protected const double triDan = 4.0;
        protected const double vecDni = 1.5;

        public virtual double Izracun(int dni)
        {
            double znesek = 0;
            if (dni > 3)
            {
                znesek = triDan + (dni - 3) * vecDni;
            }
            else
            {
                switch (dni)
                {
                    case 1:znesek = enDan;
                        break;
                    case 2:
                        znesek = dvaDan;
                        break;
                    case 3:
                        znesek = triDan;
                        break;
                }
            }

            return znesek;
        }

    }

}
