using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба5_6
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form2 form02 = new Form2();
                form02.Show();//Открытие Формы2
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                Form1 form01 = new Form1();
                this.Close(); //Закрытие Формы2
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();//Открытие Формы3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form4 = new Form();
            form4.Show();//Открытие Формы4
        }
    }
}
