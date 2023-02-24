using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki
{
    //kvader:pravokotnik = dedovanje
    internal class Kvader:pravokotnik
    {
        int visina;
        public Kvader(int x1p, int y1p, int x2p, int y2p, int vk):base(x1p, y1p, x2p, y2p)
        {
            visina = vk;
        }
        public int Prostornina()
        {
            return base.Ploscina() * visina;
        }
        public int Povrsina()
        {
            return 2 * base.Ploscina() +
                   2 * base.StranicaA() * visina +
                   2 * base.StranicaB() * visina;
        }
    }
}
