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

        public Network(int sizex, int sizey, List<Bitmap> weightNeuron)
        {
            percept = new Perceptron[10];
            for (int i = 0; i < 10; i++)
            {
                percept[i] = new Perceptron(sizex, sizey, i.ToString(), weightNeuron[i]);
            }
        }

        public void SetWeightToNeuron(Bitmap map, int index)
        {
            percept[index].setWeight(map);
            return;
        }

        public int Check(Bitmap number)
        {
            int result = -1;
            double[] answer = new double[percept.Count()];
            for (int I = 0; I < percept.Count(); I++)
            {
                answer[I] = percept[I].CheckNumber(number);
            }
            double item = answer.Max();
            result = Array.IndexOf(answer, item);
            return result;
        }

    }
}
