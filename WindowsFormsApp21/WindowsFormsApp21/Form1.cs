using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttoncolor_Click(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void buttonopen2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
            }
        }

        private void buttonopen1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void buttonopen3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Load(openFileDialog1.FileName);
            }
        }

        private void buttoncolor2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttoncolor3_Click(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            // allow multiple selection
            d.Multiselect = true;

            // filter the desired file types
            d.Filter = "JPG |*.jpg|PNG|*.png|BMP|*.bmp";

            // show the dialog and check if the selection was made
            if (d.ShowDialog() == DialogResult.OK)
            {
                foreach (string image in d.FileNames)
                {
                    // create a new control
                    PictureBox pb = new PictureBox();

                    // assign the image
                    pb.Image = new Bitmap(image);

                    // stretch the image
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    // set the size of the picture box
                    pb.Height = pb.Image.Height *2;
                    pb.Width = pb.Image.Width *2;
                    // add the control to the container
                    flowLayoutPanel1.Controls.Add(pb);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Create and initialize a VScrollBar.
            VScrollBar vScrollBar1 = new VScrollBar();

            // Dock the scroll bar to the right side of the form.
            vScrollBar1.Dock = DockStyle.Right;
        }
    }
}