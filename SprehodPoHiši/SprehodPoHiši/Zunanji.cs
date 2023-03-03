using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Zunanji:Lokacija
    {
        bool JeVroce;
        public Zunanji(string i, bool v):base(i)
        {
            JeVroce = v;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r+="Je vroče? "+JeVroce + Environment.NewLine;
            return r;
        }
    }
}
