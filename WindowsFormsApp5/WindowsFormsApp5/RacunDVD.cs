using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class RacunDVD:RacunVideo
    {
        private double kavcija = 10.0;

        public RacunDVD(double dodatek, double kavcija):base(dodatek)
        {
            this.kavcija = kavcija;

        }
        public override double Izracun(int dni)
        {
            return base.Izracun(dni) + kavcija;

        }

    }



}
