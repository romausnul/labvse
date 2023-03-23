using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString('\x58D') + Convert.ToString('\x266B') + Convert.ToString('\x263C') + Convert.ToString('\x2182') + Convert.ToString('\x214F') + Convert.ToString('\x203B') + Convert.ToString('\x1D25') + Convert.ToString('\x2042');
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i= Convert.ToInt32(textBox1.Text); i <= Convert.ToInt32(textBox2.Text);i++)
            {
                label1.Text = label1.Text+Convert.ToString(Convert.ToChar(i));   //Convert.ToString(Convert.ToInt32(textBox1.Text),16);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            button3.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
            if (textBox1.Visible == true)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(textBox3.Text, textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = ($"Количество символов: {richTextBox2.Text.Length}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
