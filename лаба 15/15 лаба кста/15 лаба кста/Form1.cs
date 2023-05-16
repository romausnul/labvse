using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_лаба_кста
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                MessageBox.Show("ТУТ ЧТО-ТО НЕ ТО");
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                textBox1.Text = (string)row.Cells[1].Value;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 1;
            dataGridView1[0, 0].Value = textBox1.Text;
            dataGridView1[0, 1].Value = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
