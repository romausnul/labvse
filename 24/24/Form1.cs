using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath=null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
            }
            
            StreamWriter S = new StreamWriter(filepath);
            S.WriteLine($"Имя: {textBox1.Text}");
            S.WriteLine($"Фамилия: {textBox2.Text}");
            S.WriteLine($"Отчество: {textBox3.Text}");
            S.WriteLine($"Пол: {textBox4.Text}");
            S.WriteLine($"Год рождения: {textBox5.Text}");
            S.WriteLine($"Адрес: {textBox6.Text}");
            S.WriteLine($"Рост: {textBox7.Text}");
            S.WriteLine($"Вес: {textBox8.Text}");
            S.WriteLine($"Группа крови: {textBox9.Text}");
            S.WriteLine($"Диагноз: {textBox10.Text}");
            S.WriteLine($"ФИО врача: {textBox11.Text}");
            S.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
