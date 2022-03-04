using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intg.Intrrr
{
    interface ICalcult
    {
        double Calcul(int count, int upLim, int downLim, Func<double, double> integral);
    }
}
