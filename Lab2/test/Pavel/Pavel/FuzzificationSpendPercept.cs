using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public class FuzzificationSpendPercept
    {
        private double _minLim = 0;
        private double _maxLim = 0;
        private double _peak = 0;

        public double minLim
        {
            get { return _minLim; }
            set { _minLim = value; }
        }

        public double maxLim
        {
            get { return _maxLim; }
            set { _maxLim = value; }
        }

        public double peak
        {
            get { return _peak; }
            set { _peak = value; }
        }

        public FuzzificationSpendPercept(double min, double max)
        {
            this._minLim = min;
            this._maxLim = max;
            this._peak = (max - min) / 2;
        }

        public double Transform(double x)
        {
            int intervalCase = 0;

            if (x >= this._minLim && x <= _peak)
                intervalCase = 1;

            if (x == _peak)
                intervalCase = 2;

            if (x >= _peak && x <= _maxLim)
                intervalCase = 3;

            double res = 0;
            switch (intervalCase)
            {
                case 1:
                    res = 1 - ((_peak - x) / (_peak - _minLim));
                    break;

                case 2:
                    res = 1;
                    break;

                case 3:
                    res = 1 - ((x - _peak) / (_maxLim - _peak));
                    break;
            }

            return res;
        }
    }
}
