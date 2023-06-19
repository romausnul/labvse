using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp256444444444444444444
{
    public partial class Form1 : Form
    {
        private Graphics paper;
        private object paddle;
        private object ball;
        private object bricks;

        public Form1()
        {
            InitializeComponent();
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Graphics gr = Graphics.FromImage(bt);
            Point p1 = new Point(30, 10);
            Point p2 = new Point(70, 10);
            Point p3 = new Point(50, 50);
            Point p4 = new Point(90, 10);
            Point p5 = new Point(70, 30);
            Point p6 = new Point(40, 30);
            Point p7 = new Point(80, 10);
            Point p8 = new Point(100, 40);
            Point p9 = new Point(50, 40);
            Point p10 = new Point(30, 40);
            Point p11 = new Point(50, 10);
            Point p12 = new Point(70, 40);
            Point p13 = new Point(50, 70);
            Point p14 = new Point(30, 50);
            Point[] P1 = { p1, p2, p3, p1 };
            Point[] P2 = { p1, p4, p5, p6, p1 };
            Point[] P3 = { p1, p7, p8, p9, p1 };
            Point[] P4 = { p1, p2, p9, p1 };
            Point[] P5 = { p10, p11, p12, p13, p10 };
            Point[] P6 = { p1, p2, p14, p1 };

            switch (num)
            {
                case 0: //круг
                    gr.Clear(Color.White);
                    gr.FillEllipse(Brushes.Black, 30, 10, 50, 50);
                    break;
                case 1: //эллипс
                    gr.Clear(Color.White);
                    gr.DrawEllipse(myPen, 30, 10, 60, 40);
                    break;
                case 2: //прямоугольник
                    gr.Clear(Color.White);
                    gr.DrawRectangle(myPen, 30, 10, 60, 40);
                    break;
                case 3: //равнобедренный треугольник
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P1);
                    break;
                case 4: //квадрат
                    gr.Clear(Color.White);
                    gr.DrawRectangle(myPen, 30, 10, 40, 40);
                    break;
                case 5: //трапеция
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P2);
                    break;
                case 6: //параллелолграмм
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P3);
                    break;
                case 7: //равносторонний треугольник
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P4);
                    break;
                case 8: //окружность
                    gr.Clear(Color.White);
                    gr.DrawEllipse(myPen, 30, 10, 40, 40);
                    break;
                case 9: //ромб
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P5);
                    break;
                case 10: //прямоугольный треугольник
                    gr.Clear(Color.White);
                    gr.DrawLines(myPen, P6);
                    break;
                default:
                    gr.Clear(Color.White);
                    MessageBox.Show("Вы ничего не выбрали");
                    break;
            }
            Picture.Image = bt;
        }
    }
    }
 }
