using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мАМОНОВ_оКОННОЕ
{
    public partial class Магазин : Form
    {
        public Магазин()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string N1 = TextBox1.Text; // Эта команда для ввода данных названия, переменная строкового типа
            String int K1 = Convert.ToInt32(TextBox2.Text); // Эта команда для ввода данных о количестве, переменная целого числового типа Integer
            double C1 = Convert.ToDouble(TextBox3.Text); // Эта команда для ввода данных о цене, переменная вещественного числового типа Double
        }
    }
}
