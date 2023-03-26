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
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString('\x058D') + Convert.ToString('\x266B') + Convert.ToString('\x263C') + Convert.ToString('\x2182') + Convert.ToString('\x214F') + Convert.ToString('\x203B') + Convert.ToString('\x1D25') + Convert.ToString('\x2042');
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
        }

        private TextBox GetTextBox2()
        {
            return textBox2;
        }

        private TextBox button1_Click(object sender, EventArgs e, TextBox textBox2)
        {
            return textBox1;
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
