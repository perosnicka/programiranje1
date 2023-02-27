using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcenV2
{
    internal class StudentAng : StudentAbs
    {
        public override string Crka()
        {
            double x = Ocena();
            if (x >= 93)
                return "A";
            if (x >= 85)
                return "B";
            if (x >= 78)
                return "C";
            if (x >= 70)
                return "D";
            return "F";
        }

        public override string Izpis()
        {
            string r = "";
            r += "******* Študent Angleščine *******";
            r += Environment.NewLine + "Delni 1 " + delni1;
            r += Environment.NewLine + "Delni 2 " + delni2;
            r += Environment.NewLine + "Seminar " + seminar;
            r += Environment.NewLine + "Ustna   " + ustna;
            r += Environment.NewLine + "Končna  " + Ocena();
            r += Environment.NewLine + "Črka    " + Crka();
            return r;
        }

        public override double Ocena()
        {
            return 0.25 * delni1 + 0.25 * delni2 + 0.3 * seminar + 0.2 * ustna;
        }
    }
}
