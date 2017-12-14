using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    //public delegate double operationByRules(double x, double y);

    public class KnowledgePercept
    {
        Functions func;
        double min;
        double max;
        double peak;
        public static double And(double x, double y)
        {
            return (x * y);
        }
        public static double Or (double x, double y)
        {
            return Math.Max(x, y); 
        }

        public KnowledgePercept(double _min, double _max, double _peak)
        {
            func = new Functions(40000);
            min = _min;
            max = _max;
            peak = _peak;
        }
        public double u(double x, double y, double z)
        {
            double arif = (x + y + z) / 3;
            if ((arif >= min) && (arif < peak))
            {
                return Math.Pow(arif, 3);
            }
            if ((arif > peak) && (arif <= max))
            {
                return Math.Pow(arif, 0.5);
            }
            return peak;
        }

        public double checkRule(double x, double y, double z)
        {
            if (Boolean.Parse(And(func.budgetFunction(x), func.flatFunction(y)).ToString() ) && Boolean.Parse(And(func.budgetFunction(x), func.transportFunction(z)).ToString()) && Boolean.Parse(And(func.transportFunction(z), func.flatFunction(y)).ToString()))
            {
                return u(func.budgetFunction(x), func.flatFunction(y), func.transportFunction(z));
            }
            return 0;
        }
    }
}
