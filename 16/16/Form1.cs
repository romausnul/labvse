using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int [] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(richTextBox1.Lines[i]);
            }
            label1.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                label1.Text += Convert.ToString(arr[i]) + ' '; 
            }
            label2.Text = "Минимальное значение: " + arr.Min() + '\n';
            label2.Text += "Максимальное значение: " + arr.Max() + '\n';
            label2.Text += "Среднее значение: " + arr.Average();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Программное добавление строк
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].HeaderCell.Value = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Программное добавление колонок
            dataGridView1.Columns.Add("","");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[,] matrs;
            matrs = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    matrs[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            int [] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(richTextBox2.Lines[i]);
            }

            label1.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                label3.Text += Convert.ToString(arr[i]) + ' ';
            }

            int indx;
            for (int i = 0; i < arr.Length; i++)
            {
                indx = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[indx])
                    {
                        indx = j;
                    }
                }
                if (arr[indx] == arr[i])
                {
                    continue;
                }
                int temp = arr[i];
                arr[i] = arr[indx];
                arr[indx] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                label4.Text += Convert.ToString(arr[i]) + ' ';
            }

            int indx1;
            for (int i = 0; i < arr.Length; i++)
            {
                indx1 = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[indx1])
                    {
                        indx1 = j;
                    }
                }
                if (arr[indx1] == arr[i])
                {
                    continue;
                }
                int temp = arr[i];
                arr[i] = arr[indx1];
                arr[indx1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                label5.Text += Convert.ToString(arr[i]) + ' ';
            }

        }
    }
}
