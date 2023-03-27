using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzpit2
{
    internal class Knjiga
    {
        string ime;
        string avtor;
        double cena;

        public string Ime { get => ime; set => ime = value; }
        public string Avtor { get => avtor; set => avtor = value; }
        public double Cena { get => cena; set => cena = value; }
    }
}
