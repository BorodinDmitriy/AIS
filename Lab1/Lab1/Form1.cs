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
                label1.Text = pbxImage.Image.Height.ToString() + " " + pbxImage.Image.Width.ToString();
            }
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            int imageSizeX = pbxImage.Image.Width;
            int imageSizeY = pbxImage.Image.Height;

            networkSnippet = new Network(imageSizeX, imageSizeY);
            imageProcessorSnippet = new ImageProcessor((Bitmap)pbxImage.Image.Clone(), networkSnippet);

            //label1.Text = imageProcessorSnippet.Check().ToString();
            //int number = networkSnippet.Check(pbxImage.Image);
            //label1.Text = number.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
