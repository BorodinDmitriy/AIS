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
        private string      _PerceptronName;
        private int         _MapSizeX;
        private int         _MapSizeY;
        private double[,]   _MemoryWeight;
        private double[,]   _MemoryIntensity;
        private double      _Limit = 75;
        private double[,]   _LastInput;

        private double getIntensity(Color rgb)
        {
            double res;
            res = (rgb.B + rgb.G + rgb.R) / 3.0;
            return res;
        }

        public string Name
        {
            get { return _PerceptronName; }
            set { _PerceptronName = value; }
        }

        public void CorrectAnswer()
        {
            for (int X = 0; X < _MapSizeX; X++)
                for (int Y = 0; Y < _MapSizeY; Y++)
                {
                    // необходимо увеличить вес пропорционально весу 
                    this._MemoryWeight[X, Y] = Math.Min(255.0, (this._MemoryWeight[X, Y] + (Math.Abs(_LastInput[X, Y]-this._MemoryWeight[X,Y]) / this._MemoryWeight[X, Y])));
                }
        }

        public void IncorrectAnswer()
        {
            for (int X = 0; X < _MapSizeX; X++)
                for (int Y = 0; Y < _MapSizeY; Y++)
                {
                    // необходимо увеличить вес пропорционально весу 
                    this._MemoryWeight[X, Y] = Math.Min(255.0, (this._MemoryWeight[X, Y] - (_LastInput[X, Y]/ this._MemoryWeight[X, Y])));
                }
        }

        public Perceptron(int sizex, int sizey, string per_name, Bitmap learning_picture)
        {
            this._MapSizeX = sizex;
            this._MapSizeY = sizey;
            this._MemoryWeight  = new double[_MapSizeX, _MapSizeY];
            this._MemoryIntensity = new double[_MapSizeX, _MapSizeY];
            this._LastInput = new double[_MapSizeX, _MapSizeY];
            double tempIntensity;
            for (int x = 0; x < learning_picture.Size.Width; x++)
            {
                for (int y = 0; y < learning_picture.Size.Height; y++)
                {
                    tempIntensity = getIntensity(learning_picture.GetPixel(x, y));
                    this._MemoryIntensity[x, y] = tempIntensity;
                    this._MemoryWeight[x, y] = (byte.MaxValue - tempIntensity);
                }
            }
            this.Name = per_name;
            return;
        }

        public double CheckNumber(Bitmap map)
        {
            double result = 0;
            double intensityMapPixel;
            double weightToMapPixel;
            double countPossiblePixelApproximation = 0;
            for (int X = 0; X < _MapSizeX; X++)
            {
                for (int Y = 0; Y < _MapSizeY; Y++)
                {
                    intensityMapPixel = getIntensity(map.GetPixel(X, Y));
                    weightToMapPixel = byte.MaxValue - intensityMapPixel;
                    _LastInput[X, Y] = weightToMapPixel;
                    // Сравнение интенсивности в памяти перцептрона с текущим изображением
                    if (Math.Abs(intensityMapPixel - this._MemoryIntensity[X, Y]) > _Limit)
                    {
                        // Если разница больше лимита, значит пиксель не удовлит. входящему изображению
                        continue;
                    }
                    else
                    {
                        // Если разница не велика, то рассматриваем приближенность интенсивностей
                        // Если интенсивности эквивалентны белому цвету, продолжить просмотр
                        if (intensityMapPixel >= 250.0)
                            continue;
                        else
                        {
                            countPossiblePixelApproximation += (this._MemoryWeight[X, Y] * weightToMapPixel)/ 255.0;
                        }
                    }
                }
            }
            //  Отношение возможно приближенных ко всем пикселям изображения
            result = countPossiblePixelApproximation;
            return result;
        }
       
    }
}
