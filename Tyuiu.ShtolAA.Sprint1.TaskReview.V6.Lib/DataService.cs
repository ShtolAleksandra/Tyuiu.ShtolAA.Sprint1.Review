using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShtolAA.Sprint1.TaskReview.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow((1 + (1 / Math.Pow(x, 2))), x) - 12 * Math.Pow(x, 2) * y,3);

            return res;
        }
    }
}
