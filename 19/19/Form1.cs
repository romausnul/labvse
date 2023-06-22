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

namespace _19
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
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                label1.Text += ($"Название: {drive.Name}{'\n'}");
                label1.Text += ($"Тип: {drive.DriveType}{'\n'}");
                if (drive.IsReady)
                {
                    label1.Text += ($"Объем диска: {drive.TotalSize}{'\n'}");
                    label1.Text += ($"Свободное пространство: {drive.TotalFreeSpace}{'\n'}");
                    label1.Text += ($"Метка диска: {drive.VolumeLabel}{'\n'}{'\n'}");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string papka = "C:\\users\\admin";
            if (Directory.Exists(papka))
            {
                label2.Text = "Подкаталоги:" + '\n';
                string[] dirs = Directory.GetDirectories(papka);
                foreach (string s in dirs)
                {
                    label2.Text += s + '\n';
                }
                label2.Text += "\n";
                label2.Text += "Файлы:" + '\n';
                string[] files = Directory.GetFiles(papka);
                foreach (string s in files)
                {
                    label2.Text += s + "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string papka = $@"{textBox1.Text}";
            string subpapka = $@"genka";
            DirectoryInfo dirinfo = new DirectoryInfo(papka);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            dirinfo.CreateSubdirectory(subpapka);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string papka = $@"{textBox1.Text}\genka";
                DirectoryInfo dirInfo = new DirectoryInfo(papka);
                if (dirInfo.Exists)
                {
                    dirInfo.Delete(true);
                }
            }
        }
    }
}
