using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics.Intrrr
{
    class Trapec : ICalcult
    {
        double ICalcult.Calcul(int count, double upLim, double downLim, Func<double, double> integral)
        {
            double h = (upLim - downLim) / count;
            double sum = 0;

            //a += h * k;

            for (int i = 1; i < count-1; i++)
            {
                sum += integral(downLim + h * i);
            }
            sum += integral(downLim) + integral(upLim) / 2;
            return h * sum;
        }
    }
}
