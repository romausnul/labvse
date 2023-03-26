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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            {
                Form2 form02 = new Form2();
                form02.Show(); //Открытие Формы2
                this.Hide(); //Скрывание Формы1

            }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            this.Close(); //Закрытие формы
            Application.Exit(); //Завершение проекта
        }
    }
}
