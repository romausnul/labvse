using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap IZOBR = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(IZOBR);

            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            SolidBrush br = new SolidBrush(Color.Gray);
            g.FillRectangle(br, 0, pictureBox1.Height/2, pictureBox1.Width, pictureBox1.Height);
            Pen pen2 = new Pen(Color.White, 5);
            int x1 = 20;
            int x2 = 70;
            g.DrawLine(pen2, x1, 250, x2, 250);
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(pen2, x1 += 70, 250, x2 += 70, 250);
            }
            x1 = 20;
            x2 = 70;
            g.DrawLine(pen2, x1, 350, x2, 350);
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(pen2, x1 += 70, 350, x2 += 70, 350);
            }

            SolidBrush br1 = new SolidBrush(Color.Red);
            g.FillRectangle(br1, 15, 20, 20, 70);
            g.FillRectangle(br1, 40, 20, 120, 30);
            g.FillRectangle(br1, 15, 95, 220, 80);
            g.FillRectangle(br1, 235, 40, 65, 135);
            SolidBrush br2 = new SolidBrush(Color.Black);
            int y1;
            int y2;
            x1 = 20;
            x2 = 45;
            y1 = 155;
            y2 = 49;
            Rectangle rect = new Rectangle(x1, y1, x2, y2);
            g.FillEllipse(br2, rect);
            x1 = 200;
            x2 = 45;
            y1 = 155;
            y2 = 49;
            Rectangle rect2 = new Rectangle(x1, y1, x2, y2);
            g.FillEllipse(br2, rect2);
            g.DrawLine(pen, 305, 40, 390, 100);
            g.DrawLine(pen, 305, 40, 305, 100);
            g.DrawLine(pen, 305, 100, 390, 100);
            g.FillRectangle(br1, 305, 105, 88, 70);

            x1 = 320;
            x2 = 45;
            y1 = 155;
            y2 = 49;
            Rectangle rect3 = new Rectangle(x1, y1, x2, y2);
            g.FillEllipse(br2, rect3);
            SolidBrush br3 = new SolidBrush(Color.White);
            g.FillRectangle(br3, 450, 270, 200, 70);
            g.FillRectangle(br3, 530, 165, 120, 100);
            x1 = 460;
            x2 = 45;
            y1 = 320;
            y2 = 45;
            Rectangle rect4 = new Rectangle(x1, y1, x2, y2);
            g.FillEllipse(br2, rect4);
            x1 = 590;
            x2 = 45;
            y1 = 320;
            y2 = 45;
            Rectangle rect5 = new Rectangle(x1, y1, x2, y2);
            g.FillEllipse(br2, rect5);
            g.DrawLine(pen, 450, 265, 525, 265);
            g.DrawLine(pen, 450, 265, 525, 165);
            g.DrawLine(pen, 525, 165, 525, 265);
            pictureBox1.Image = IZOBR;
        }
    }
}
