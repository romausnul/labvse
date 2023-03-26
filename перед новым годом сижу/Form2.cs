using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace перед_новым_годом_сижу
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form01 = new Form1();
            form01.Show();//Открытие Формы1
            this.Close(); //Закрытие Формы2
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string N1 = textBox1.Text;
            int K1 = Convert.ToInt32(textBox4.Text);
            double C1 = Convert.ToDouble(textBox9.Text);
            string N2 = textBox5.Text;
            int K2 = Convert.ToInt32(textBox3.Text);
            double C2 = Convert.ToDouble(textBox8.Text);
            string N3 = textBox6.Text;
            int K3 = Convert.ToInt32(textBox2.Text);
            double C3 = Convert.ToDouble(textBox7.Text);
            Double Ob_st = K1 * C1 + K2 * C2 + K3 * C3;
            label8.Text = Convert.ToString(Ob_st);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
