using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox1.Text);
            int[] mas1 = new int[n];
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = Convert.ToInt32(richTextBox1.Lines[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ("");
            label2.Text = ("");
            Random random = new Random();
            int[] rand = new int[10];
            for (int i = 0; i < rand.Length; i++)
            {
                rand[i] = random.Next(-100, 100);
            }
            for (int i = 0; i < rand.Length; i++)
            {
                label1.Text=label1.Text +' '+ Convert.ToString(rand[i]);
            }

            for(int i = 0; i < rand.Length; i++)
            {
                if (rand[i] < 0)
                {
                    rand[i] = -(rand[i]);
                }
                label2.Text = label2.Text + ' ' + Convert.ToString(rand[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("");
            label2.Text = ("");
            label3.Text = ("");
        }
    }
}
