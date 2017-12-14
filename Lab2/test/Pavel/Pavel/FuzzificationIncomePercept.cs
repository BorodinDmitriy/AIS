using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public class FuzzificationIncomePercept
    {
        private double _lowMinLim = 0;
        private double _highMinLim = 0;
        private double _lowMaxLim = 0;
        private double _highMaxLim = 0;

        public double lowMinLim
        {
            get { return _lowMinLim; }
            set { _lowMinLim = lowMinLim; }
        }

        public double highMinLim
        {
            get { return _highMinLim; }
            set { _highMinLim = highMinLim; }
        }

        public double lowMaxLim
        {
            get { return _lowMaxLim; }
            set { _lowMaxLim = lowMaxLim; }
        }

        public double highMaxLim
        {
            get { return _highMaxLim; }
            set { _highMaxLim = highMaxLim; }    
        }
        
        public FuzzificationIncomePercept(double min, double max, double step)
        {
            _lowMinLim = min;
            _highMaxLim = max - max * step;
            _lowMaxLim = max;
            _highMinLim = min + min * step;
        }

        public double Transform(double x)
        {
            int intervalCase = 0;

            if (x >= this._lowMinLim && x <= _highMinLim)
                intervalCase = 1;

            if (x >= _highMinLim && x <= _highMaxLim)
                intervalCase = 2;

            if (x >= _highMaxLim && x <= _lowMaxLim)
                intervalCase = 3;

            if (intervalCase > 0)
            {
                double res = 0;
                switch (intervalCase)
                {
                    case 1:
                        res = 1 - ((_highMinLim - x) / (_highMinLim - _lowMinLim));
                        break;

                    case 2:
                        res = 1;
                        break;

                    case 3:
                        res = 1 - ((x - _highMaxLim) / (_lowMaxLim - _highMaxLim));
                        break;

                    default:
                        res = double.NaN;
                        break;
                }

                return res;
            }
            else
                return double.NaN;
        }
    }
}
