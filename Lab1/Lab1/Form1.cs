using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Network networkSnippet;
        ImageProcessor imageProcessorSnippet;
        int _LastNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbxImage.Image = new Bitmap(open.FileName);
                label3.Text = "";
                label1.Text = pbxImage.Image.Height.ToString() + " " + pbxImage.Image.Width.ToString();
            }
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            Bitmap map = new Bitmap(pbxImage.Image);
            imageProcessorSnippet.SetImage(map);
            int number = imageProcessorSnippet.processImage();
            this._LastNumber = number;
            label3.Text = number.ToString();


            /*networkSnippet = new Network(imageSizeX, imageSizeY);
            imageProcessorSnippet = new ImageProcessor((Bitmap)pbxImage.Image.Clone(), networkSnippet);

            label1.Text = imageProcessorSnippet.Check().ToString();*/
            //int number = networkSnippet.Check(pbxImage.Image);
            //label1.Text = number.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Bitmap> initBitmaps = new List<Bitmap>();
            for (int i = 0; i < 10; i++)
            {
                initBitmaps.Add(new Bitmap("./../../min_img/" + i.ToString() + ".jpg"));
            }
            networkSnippet = new Network(initBitmaps[0].Width, initBitmaps[0].Height, initBitmaps);
            imageProcessorSnippet = new ImageProcessor(networkSnippet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.networkSnippet.CorrectAnswer(this._LastNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.networkSnippet.IncorrectAnswer(this._LastNumber);
        }
    }
}
