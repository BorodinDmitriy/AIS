using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Lab1
{
    class Perceptron
    {
        public string name;
        public int[,] scale_signal;
        public int[,] weight;
        public int[,] input;
        public int[,] memory;
        public double result;
        public int sum;
        private int sizeX;
        private int sizeY;

        public Perceptron(int sizex, int sizey, string per_name)
        {
            weight = new int[sizex, sizey];
            input = new int[sizex, sizey];
            scale_signal = new int[sizex, sizey];
            memory = new int[sizex, sizey];
            sizeX = sizex;
            sizeY = sizey;
            result = 0;
            name = per_name;
            return;
        }

        public void setWeigth(Bitmap map)
        {
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    weight[x, y] = map.GetPixel(x, y).A;
                    memory[x, y] = map.GetPixel(x, y).A;
                }
            return;
        }

        public string CheckNumber(Bitmap map)
        {

        }
       
    }
}
