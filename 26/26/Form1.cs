using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap IZOBR = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics GRAF = Graphics.FromImage(IZOBR);
            Pen Pero = new Pen(Color.Red, 3);
            GRAF.DrawLine(Pero, 0, 0, 100, 5);
            Pen Pero2 = new Pen(Color.Blue, 5);
            GRAF.DrawRectangle(Pero2, 100, 20, 60, 120);
            SolidBrush br = new SolidBrush(Color.Green);
            GRAF.FillRectangle(br, 100, 20, 60, 120);
            pictureBox1.Image = IZOBR;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap IZOBR = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics GRAF = Graphics.FromImage(IZOBR);
            Pen Pero = new Pen(Color.Black, 4);
            GRAF.DrawRectangle(Pero, 150, 90, 100, 140);
            GRAF.DrawLine(Pero, 150, 90, 200, 70);
            GRAF.DrawLine(Pero, 200, 70, 250, 90);
            pictureBox2.Image = IZOBR;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap IZOBR = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            Graphics GRAF = Graphics.FromImage(IZOBR);
            Pen Pero = new Pen(Color.Blue, 4);
            int x = 1;
            int y = 1;
            int width = 50;
            int height = 50;
            GRAF.DrawEllipse(Pero, x, y, width, height);
            x = 55;
            Pen Pero1 = new Pen(Color.Black, 4);
            GRAF.DrawEllipse(Pero1, x, y, width, height);
            x = 110;
            Pen Pero2 = new Pen(Color.Red, 4);
            GRAF.DrawEllipse(Pero2, x, y, width, height);
            x = 25;
            y = 30;
            Pen Pero3 = new Pen(Color.Yellow, 4);
            GRAF.DrawEllipse(Pero3, x, y, width, height);
            x = 85;
            Pen Pero4 = new Pen(Color.Green, 4);
            GRAF.DrawEllipse(Pero4, x, y, width, height);
            pictureBox3.Image = IZOBR;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap IZOBR = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            Graphics GRAF = Graphics.FromImage(IZOBR);
            Pen Pero = new Pen(Color.Blue, 4);
            int x = 1;
            int y = 1;
            int width = 100;
            int height = 100;
            GRAF.DrawEllipse(Pero, x, y, width, height);
            pictureBox4.Image = IZOBR;
        }
    }
}
