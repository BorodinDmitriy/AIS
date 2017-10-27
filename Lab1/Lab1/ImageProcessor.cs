using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    class ImageProcessor
    {
        private int sizeX;
        private int sizeY;
        private Bitmap image;
        private Network net;

        public ImageProcessor(Network workingNetwork)
        {
            net = workingNetwork;
        }

        public void SetImage(Bitmap pic)
        {
            image = pic;
            sizeX = image.Width;
            sizeY = image.Height;
            return;
        }
        public int processImage()
        {
            int number = net.Check(image);
            return number;
        }
    }
}
