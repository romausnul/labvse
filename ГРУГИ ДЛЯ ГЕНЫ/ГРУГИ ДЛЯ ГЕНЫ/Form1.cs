using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Red), new Rectangle(10, 10, 50, 50));

            e.Graphics.FillEllipse(Brushes.Red, 10, 10, 50, 50);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
