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
        private int limit = 125;
        public Perceptron(int sizex, int sizey, string per_name, Bitmap new_weight)
        {
            sizeX   = sizex;
            sizeY   = sizey;
            weight  = new int[sizex, sizey];
            memory  = new int[sizex, sizey];
            for (int x = 0; x < new_weight.Size.Width; x++)
            {
                for (int y = 0; y < new_weight.Size.Height; y++)
                {
                    var temp = new_weight.GetPixel(x, y);
                    weight[x, y] = new_weight.GetPixel(x, y).A;
                    memory[x, y] = new_weight.GetPixel(x, y).A;
                }
            }
            input = new int[sizex, sizey];
            scale_signal = new int[sizex, sizey];
            result = 0;
            name = per_name;
            return;
        }

        public void setWeight(Bitmap map)
        {
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    weight[x, y] = map.GetPixel(x, y).A;
                    memory[x, y] = map.GetPixel(x, y).A;
                }
            return;
        }

        public double CheckNumber(Bitmap map)
        {
            double result = 0;
            int alpha_map;
            int weight_for_check = 0;
            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    alpha_map = map.GetPixel(x, y).A;
                    if (Math.Abs(alpha_map - memory[x, y]) < limit)
                    {
                        if (alpha_map < 250)
                            weight_for_check++;
                    }
                    if (alpha_map != 0)
                    {
                        if(alpha_map < 250)
                            memory[x, y] = Convert.ToInt32(Math.Round((memory[x, y] + (memory[x, y] + alpha_map) / 2.0) / (2.0)));
                        else if (memory[x,y] != 0)
                            if(alpha_map < 250)
                                memory[x, y] = Convert.ToInt32(Math.Round((memory[x, y] + (memory[x, y] + alpha_map) / 2.0) / (2.0)));
                    }
                }
            }
            result = weight_for_check;
            return result;
        }
       
    }
}
