using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratornaya15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            int o = 0;
            Random f = new Random();
            int[,] num1 = new int[3, 3];
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                { num1[i, j] = f.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(num1[i, j]);
                    if (num1[i, j] >= 0) p++;
                    else o++;
                    label1.Text = Convert.ToString(p) + ' ' + Convert.ToString(o);
                                 
                }


        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
