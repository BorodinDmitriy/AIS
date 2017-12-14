using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public delegate double operationByRules(double x, double y);

    public class KnowledgePercept
    {
        public static double And(double x, double y)
        {
            return x * y;
        }
        public static double Or (double x, double y)
        {
            return Math.Max(x, y);
        }
        public KnowledgePercept(double val, operationByRules method, operationByRules method2, double min, double max, double peak)
        {

        }
    }
}
