using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДОМИК_ДЛЯ_гЕНЫ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
           protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawHouse(e);
        }

        private void DrawHouse(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.FromLTRB(100, 100, 300, 300));
            e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Red), new Rectangle(10, 10, 50, 50));

            using (var pen = new Pen(Color.Black, 2))

            {
                e.Graphics.DrawLine(pen, 70, 130, 200, 0);
                e.Graphics.DrawLine(pen, 200, 0, 330, 130);
         

                e.Graphics.FillEllipse(Brushes.Black, 100, 10, 50, 50);
            }
        }
    
    }
}

