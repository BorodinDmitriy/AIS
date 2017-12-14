using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    class FuzzificationCarSpendPercept
    {
        private double _c = 0;
        private double _gamma = 0;

        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        public double gamma
        {
            get { return _gamma; }
            set { _gamma = value; }
        }

        public FuzzificationCarSpendPercept(double c, double gamma)
        {
            this._c = c;
            this._gamma = gamma;
        }

        public double Transform(double x)
        {
            double res = Math.Exp(-1 * Math.Pow((x - this._c) / this._gamma, 2));
            return res;
        }
    }
}
