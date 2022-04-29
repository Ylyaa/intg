using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace intg.Intrrr
{ 
    public class TrapezoidalMethod : ICalcult
    {
        double ICalcult.Calcul(int count, double upLim, double downLim, Func<double, double> integral, out double time)
        {
            Stopwatch tn = new Stopwatch();
            tn.Start();

            double h = (upLim - downLim) / count;
            double sum = 0.0;

            for (int i = 0; i < count; i++)
            {
                sum += integral(downLim + h * i);
            }
            tn.Stop();
            TimeSpan tk = tn.Elapsed;
            time = tk.TotalMilliseconds;
            return h * ((integral(downLim) + integral(upLim)) / 2 + sum);
        }
}