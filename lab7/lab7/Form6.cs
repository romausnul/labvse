using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = Convert.ToDateTime(this.textBox1.Text);
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, birthday.Month, birthday.Day);

            if (next < today)
                next = next.AddYears(1);
            int days = (next - today).Days;
            this.label1.Text = $"Следующий день рождения через {days} дней";
        }
    }
}
