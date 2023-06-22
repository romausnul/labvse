using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
            await streamWriter.WriteAsync(richTextBox1.Text);
            streamWriter.Close();
            StreamReader streamReader = new StreamReader(saveFileDialog1.FileName);*/

            FileStream FS2 = new FileStream(@"D:\F.Bin", FileMode.Open, FileAccess.Read);
            BinaryReader BR1 = new BinaryReader(FS2);
            for(int i = 0; i < 10; i++)
            {
                int num = BR1.ReadInt32();
                if (num % 2 == 0)
                {
                    FileStream FS3 = new FileStream(@"D:\C.bin", FileMode.Append);
                    BinaryWriter BW2 = new BinaryWriter(FS3);
                    {
                        BW2.Write(num);
                    }
                    BW2.Close();
                    FS3.Close();
                }
                else
                {
                    FileStream FS4 = new FileStream(@"D:\N.bin", FileMode.Append);
                    BinaryWriter BW3 = new BinaryWriter(FS4);
                    {
                        BW3.Write(num);
                    }
                    BW3.Close();
                    FS4.Close();
                }
            }
            BR1.Close();
            FS2.Close();
            FileStream FS7 = new FileStream(@"D:\E.bin", FileMode.Open, FileAccess.Read);
            BinaryReader BW4 = new BinaryReader(FS7);
            {
                for (int i = 0; i < 10; i++)
                {
                    int n1 = BW4.ReadInt32();
                    label1.Text = $"{n1}" + '\n';
                }
            }
            BW4.Close();
            FS7.Close();
            FileStream FS5 = new FileStream(@"D:\C.bin", FileMode.Open, FileAccess.Read);
            BinaryReader BW6 = new BinaryReader(FS5);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                
        }
    }
}
