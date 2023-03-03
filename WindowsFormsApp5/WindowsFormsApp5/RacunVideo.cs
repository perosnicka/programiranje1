using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class RacunVideo:RacunCD
    {
        protected double dodatek;

        public RacunVideo(double dodatek)
        {
            this.dodatek = dodatek;
        }

        public override double Izracun(int dni)
        {
            return base.Izracun(dni) + dni * dodatek;
        }

    }
}
