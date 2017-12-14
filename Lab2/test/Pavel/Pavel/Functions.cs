using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public class Functions
    {
        Random randObj;
        double val;
        public Functions(double value)
        {
            randObj = new Random();
            val = value;
        }

        public double budgetFunction(double x)
        {
            return Math.Pow(val * randObj.NextDouble(), 1.1) * x + Math.Pow(Math.Sin(x), 7); 
        }

        public double flatFunction(double y)
        {
            return Math.Pow(Math.Sqrt(val) * randObj.NextDouble(), 0.32) * y;
        }

        public double transportFunction(double z)
        {
            return Math.Pow(Math.Sqrt(val) * randObj.NextDouble(), 0.05) * Math.Pow(z,1.04);
        }
    }
}
