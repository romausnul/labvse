using System;
using System.Drawing;
using System.Windows.Forms;


class BallDrawing : Form
{
    public BallDrawing()
    {
        this.Paint += new PaintEventHandler(DrawBall);
        this.Size = new Size(300, 300);
    }

    void DrawBall(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen p = new Pen(Color.Black, 3);

        // Рисуем мячик
        g.DrawEllipse(p, 50, 50, 200, 200);
    }

    static void Main()
    {
        Application.Run(new BallDrawing());
    }
}