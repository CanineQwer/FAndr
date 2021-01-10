using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double a = Convert.ToDouble(LA.Text);
            double b = Convert.ToDouble(LB.Text);
            double c = Convert.ToDouble(LC.Text);
            double x1 = Convert.ToDouble(LX1.Text);
            double x2 = Convert.ToDouble(LX2.Text);
            double x3 = Convert.ToDouble(LX3.Text);
            for (double x = x1; x < x2; x = x + x3)
            {
                double f;
                if ((x < 3) & (b != 0))
                    f = a * Math.Pow(x, 2) - b * x + c;
                else
                    if ((x > 3) & (b == 0))
                    f = (x - a) / (x - c);
                else
                    f = x / c;
                dataGridView1.Rows.Add(f, x);
            }
        }
    }
}
