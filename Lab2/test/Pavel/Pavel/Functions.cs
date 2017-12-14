using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public class Functions
    {
        double val;
        public Functions(double value)
        {
            
            val = value;
        }

        public double budgetFunction(double x)
        {
            Random randObj = new Random(Convert.ToInt32(val));
            return randObj.NextDouble() * x; 
        }

        public double flatFunction(double y)
        {
            Random a = new Random(Convert.ToInt32(Math.Sqrt(val)));
            return a.NextDouble() * y;
        }

        public double transportFunction(double z)
        {
            Random a = new Random(Convert.ToInt32(Math.Log10(val)));
            return a.NextDouble() * z;
        }

        public double u(double x, double y, double z)
        {
            return Math.Log10(Math.Sin(x) + Math.Pow(y, 0.33) + Math.Log(z));
        }
    }
}
