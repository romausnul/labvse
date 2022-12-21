using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЧАЙ_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
            {
                Form2 form02 = new Form2();
                form02.Show(); //Открытие Формы2
                this.Hide(); //Скрывание Формы1
            }
        }
    }
}
