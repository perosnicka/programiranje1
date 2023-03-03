using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class StudentMehatronika : Student
    {
        public override void Racunaj()
        {
            povp = 0.5 * vmesna + 0.5 * koncna;

            if (povp >= 90)
                ocena = 10;
            else if (povp >= 80)
                ocena = 9;
            else if (povp >= 70)
                ocena = 8;
            else if (povp >= 60)
                ocena = 7;
            else if (povp >= 50)
                ocena = 6;
            else
                ocena = 5;
        }
    }
}
