using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Perceptron
    {
        public int[,] scale_signal;
        public int[,] weight;
        public int[,] input;
        public int limit = 9;
        public int sum;
        private int sizeX;
        private int sizeY;

        public Perceptron(int sizex, int sizey)
        {
            weight = new int[sizex, sizey];
            input = new int[sizex, sizey];
            scale_signal = new int[sizex, sizey];
            sizeX = sizex;
            sizeY = sizey;
            return;
        }

        public void mul_w()
        {
            for (int x = 0; x <= (sizeX - 1); x++)
            {
                for (int y = 0; y <= (sizeY - 1); y++)
                {
                    scale_signal[x, y] = input[x, y] * weight[x, y];
                }
            }
        }

        public void Sum()
        {
            sum = 0;
            for (int x = 0; x <= sizeX; x++)
            {
                for (int y = 0; y <= sizeY; y++)
                {
                    sum += scale_signal[x, y];
                }
            }
        }

        public bool Cmp()
        {
            if (sum >= limit)
                return true;
            return false;
        }
    }
}
