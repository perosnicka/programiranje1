using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal interface IProduct
    {
        int GetID();
        string GetIme();
        double GetCena();
    }
}
