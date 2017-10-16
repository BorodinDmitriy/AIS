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

        public ImageProcessor(Bitmap processingImage, Network workingNetwork)
        {
            image = processingImage;
            sizeX = image.Width;
            sizeY = image.Height;
            net = workingNetwork;
        }
        public int processImage()
        {
            int number = net.Check(image);
            return number;
        }
    }
}
