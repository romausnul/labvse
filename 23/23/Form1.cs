using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream(@"D:\1.txt", FileMode.Create, FileAccess.Write);
            string text = textBox1.Text;
            byte[] MF = Encoding.Default.GetBytes(text);
            F.Write(MF, 0, text.Length);
            F.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream(@"D:\2.txt", FileMode.Create, FileAccess.Write);
            string text = richTextBox1.Text;
            byte[] MF = Encoding.Default.GetBytes(text);
            F.Write(MF, 0, text.Length);
            F.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream F1 = new FileStream(@"D:\1.txt", FileMode.Open, FileAccess.Read);
            byte[] MF1 = new byte[F1.Length];
            F1.Read(MF1, 0, Convert.ToInt32(F1.Length));
            string text1 = Encoding.Default.GetString(MF1);
            F1.Close();

            FileStream F2 = new FileStream(@"D:\2.txt", FileMode.Open, FileAccess.Read);
            byte[] MF2 = new byte[F2.Length];
            F2.Read(MF2, 0, Convert.ToInt32(F2.Length));
            string text2 = Encoding.Default.GetString(MF2);
            F2.Close();
            FileStream F = new FileStream(@"D:\1.txt", FileMode.Append, FileAccess.Write);
            byte[] MF = Encoding.Default.GetBytes(text2);
            F.Write(MF, 0, text2.Length);
            F.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream(@"D:\1.txt", FileMode.Open, FileAccess.Read);
            byte[] MF = new byte[F.Length];
            F.Read(MF, 0, Convert.ToInt32(F.Length));
            F.Close();
            string text = Encoding.Default.GetString(MF);
            label1.Text = text;
        }
    }
}
