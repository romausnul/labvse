using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace лаба_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int com = str1.CompareTo(str2);
            if (com == 0)
                label1.Text = "Строки равны";
            if (com == 1)
                label1.Text = "Первая строка больше вторая";
            if (com == -1)
                label1.Text = "Вторая строка больше первой";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text[i] ==' ')
                {
                    if (textBox3.Text[i+1]==' ')
                    {
                        for (int j = i + 1; j < textBox3.Text.Length; j++)
                        {
                            textBox3.Text = textBox3.Text.Remove(j, 1);
                            if (textBox3.Text[j] != ' ')
                                break;
                        }
                    }
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox4.Text;
            char [] strReverse =str.ToCharArray();
            Array.Reverse(strReverse);
            string str1;
            str1 = new string(strReverse);
            if (str == str1)
            {
                label2.Text = "Это ПАЛИНОДРОМ";
            }
            else
                label2.Text = "Это нету тут ПАЛИНОДРОМ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
