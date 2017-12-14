using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public delegate double operation(double x, double y, double z);
    class DefuzzificationPercept
    {
        operation u;
        public DefuzzificationPercept(operation m)
        {
            u = m;
        }
        public double Transform1(List<double> a)
        {
            return a.Sum() / a.Count;
        }
        public double Transform2(double min, double max)
        {
            double step = (max - min) / 10000000;
            double start = min;

            double sum = 0;
            while (start < max) {
                sum += (u(start, 1, 1) + u(start + step, 1, 1)) / 2 * step;
                start += step;
            }
            return sum;
        }
    }
}
