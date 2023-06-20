using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(
                $"Сегодня {dateTime}",
                $"Сегодня {dateTime}",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(textBox1.Text);
            bool leap = DateTime.IsLeapYear(dateTime.Year);
            if (leap == true)
            {
                MessageBox.Show("Год високосный");
            }
            else
            {
                MessageBox.Show("Год невисокосный");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = Convert.ToDateTime(textBox2.Text).Date;
            MessageBox.Show(
                $"{date:D}" + '\n' +
                $"{date:d}" + '\n' +
                $"{date:f}" + '\n'+
                $"{date:G}" + '\n'+
                $"{date:g}" + '\n'+
                $"{date:M}" + '\n'+
                $"{date:O}" + '\n'+
                $"{date:o}" + '\n'+
                $"{date:R}" + '\n'+
                $"{date:r}" + '\n');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = new DateTime();
            DateTime dateTime2 = new DateTime();
            dateTime1 = Convert.ToDateTime(textBox3.Text);
            dateTime2 = Convert.ToDateTime(textBox4.Text);
            int result = DateTime.Compare(dateTime1, dateTime2);
            if (result == 0)
            {
                MessageBox.Show("Обе даты равны");
            }
            if (result > 0)
            {
                MessageBox.Show("Первая дата позже второй");
            }
            if (result < 0)
            {
                MessageBox.Show("Первая дата раньше второй");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
