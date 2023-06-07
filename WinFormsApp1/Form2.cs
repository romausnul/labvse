using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private object zs;
        private object listBox1;
        private int a;
        private object label2;
        private object textBox2;
        private TextBox form2;

        public TextBox GetForm2()
        {
            return form2;
        }

        private void SetForm2(TextBox value)
        {
            form2 = value;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int x, y, z;

            if (!Int32.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("в textBox1 не число");
            }
            if (!Int32.TryParse(button1.Text, out y))
            {
                MessageBox.Show("Я не смог определить где тут чай");
            }
            if (!Int32.TryParse(textBox3.Text, out z))
            {
                MessageBox.Show("в textBox3 не число");
            }

            string result = x > y && x > z ? $"число {x} больше"
            : y > x && y > z ? $"число {y} больше"
            : z > x && z > y ? $"число {z} больше"
            : "числа равны";

            MessageBox.Show(result);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
