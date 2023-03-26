using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            //if (!Char.IsDigit(number)) //только цифры
            //{
            //    e.Handled = true;
            //}



            //if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            //{
            //    e.Handled = true;
            //}



            //if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            //{
            //    e.Handled = true;
            //}



            //if (e.KeyChar <= 47 || e.KeyChar >= 58) //только цифры на ASCII
            //{
            //    e.Handled = true;
            //}



            //if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            //{
            //    e.Handled = true;
            //}



            //if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
            //{
            //    e.Handled = true;
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
