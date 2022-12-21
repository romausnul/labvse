using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox2.Text);
            double s2 = Convert.ToDouble(textBox6.Text);
            double s3 = Convert.ToDouble(textBox6.Text);
            label7.Text = Convert.ToString($"{(s1 + s2) * s3} часов отработано");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
