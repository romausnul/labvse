using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
            FileInfo file = new FileInfo(filePath);
            label1.Text = $"Файл: {file.Name}{'\n'}" +
                $"Размер: {file.Length}{'\n'}" +
                $"Расширение: {file.Extension}{'\n'}" +
                $"Дата создания: {file.CreationTime}";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
            FileInfo file = new FileInfo(filePath);
            file.Delete();
            MessageBox.Show("Файл удален");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            string text = textBox1.Text;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath=saveFileDialog1.FileName;
            }

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLineAsync(text);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var filePath1 = string.Empty;
            var filePath2 = string.Empty;
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                filePath1 = openFileDialog3.FileName;
            }
            FileInfo file1name = new FileInfo(filePath1);
            saveFileDialog2.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog2.FileName= file1name.Name;
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                filePath2 = saveFileDialog2.FileName;
            }
            FileInfo file = new FileInfo (filePath1);
            if (file.Exists)
            {
                file.CopyTo(filePath2);
            }
        }
    }
}
