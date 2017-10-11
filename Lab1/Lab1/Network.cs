using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    class Network
    {
        private Perceptron[] percept;
        public Network(int sizex, int sizey)
        {
            percept = new Perceptron[10];
            for (int i = 0; i < 10; i++)
            {
                percept[i] = new Perceptron(sizex, sizey, i.ToString());
            }
        }

        public void SetWeigthToNeuron(Bitmap map, int index)
        {
            percept[index].setWeigth(map);
            return;
        }

        public int CheckNumber(Bitmap map)
        {

        }
    }
}
