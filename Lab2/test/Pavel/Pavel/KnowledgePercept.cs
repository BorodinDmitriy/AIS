using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public delegate double operationbyrules(double x, double y);

    public class KnowledgePercept
    {
        Functions func;
        double min;
        double max;
        double peak;
        operationbyrules method1;
        operationbyrules method2;
        operationbyrules method3;
        public static double And(double x, double y)
        {
            return (x * y);
        }
        public static double Or (double x, double y)
        {
            return Math.Max(x, y); 
        }

        public KnowledgePercept(double _min, double _max, double _peak, operationbyrules met1, operationbyrules met2, operationbyrules met3)
        {
            func = new Functions(40000);
            min = _min;
            max = _max;
            peak = _peak;
            method1 = met1;
            method2 = met2;
            method3 = met3;
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
            if (Convert.ToBoolean(method1(func.budgetFunction(x), func.flatFunction(y))) && Convert.ToBoolean(method2(func.budgetFunction(x), func.transportFunction(z))) && Convert.ToBoolean(method3(func.transportFunction(z), func.flatFunction(y))))
            {
                return u(func.budgetFunction(x), func.flatFunction(y), func.transportFunction(z));
            }
            return 0;
        }
    }
}
