using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] a = new int[5, 10];

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = random.Next(100);
                }

            }
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = a.GetLength(0);
            dataGridView1.ColumnCount = a.GetLength(1);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            int p = 0;
            int o = 0;
            Random f = new Random();
            int[,] num1 = new int[3, 3];
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num1[i, j] = f.Next(-100, 100);
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(num1[i, j]);
                    if (num1[i, j] >= 0) p++;
                    else o++;
                    
                }
            }
            label1.Text = Convert.ToString(p) + ' ' + Convert.ToString(o);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int columns = 5;
            int rows = 5;
            int[,] a = new int[columns, rows];

            dataGridView3.ColumnCount = columns;
            dataGridView3.RowCount = rows;

            Random random = new Random();
            for (int i = 0; i < columns; i++)
            {
                for(int j = 0; j <= rows; j++)
                {
                    a[i,j] = random.Next(2,5);
                    dataGridView3.Rows[j].Cells[i].Value = a[i, j];
                    if (a[i, j] == 2) a[i, j] = 3;
                    dataGridView4.Rows[j].Cells[i].Value = a[i, j];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] num1 = new int[6, 6] { { 1, 1, 1, 1, 1, 0 }, { 2, 0, 1, 1, 0, 4 }, { 2, 2, 0, 0, 4, 4 }, { 2, 2, 0, 0, 4, 4 }, { 2, 0, 3, 3, 0, 4 }, { 0, 3, 3, 3, 3, 0 } };
            dataGridView5.RowCount = 6;
            dataGridView5.ColumnCount = 6;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    dataGridView5.Rows[i].Cells[j].Value = Convert.ToString(num1[i, j]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] num1 = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 2, 0, 1, 1, 1, 1 }, { 2, 2, 0, 1, 1, 1 }, { 2, 2, 2, 0, 1, 1 }, { 2, 2, 2, 2, 0, 1 }, { 2, 2, 2, 2, 2, 0 } };
            dataGridView6.RowCount = 6;
            dataGridView6.ColumnCount = 6;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    dataGridView6.Rows[i].Cells[j].Value = Convert.ToString(num1[i, j]);
        }
    }
}
