using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            chart1.Visible = true;

            double[] t = new double[7];
            double[] x = new double[7];
            x[0] = double.Parse(x1.Text);
            x[1] = double.Parse(x2.Text);
            x[2] = double.Parse(x3.Text);
            x[3] = double.Parse(x4.Text);
            x[4] = double.Parse(x5.Text);
            x[5] = double.Parse(x6.Text);
            x[6] = double.Parse(x7.Text);

            t[0] = double.Parse(t1.Text);
            t[1] = double.Parse(t2.Text);  
            t[2] = double.Parse(t3.Text);
            t[3] = double.Parse(t4.Text);
            t[4] = double.Parse(t5.Text);
            t[5] = double.Parse(t6.Text);
            t[6] = double.Parse(t7.Text);

            double tsum = 0;
            double xsum = 0;
            double tkvadrat = 0;
            double tx = 0;

            for (int i = 0; i < x.Length; i++)
            {
                tsum += t[i];
                xsum += x[i];
                tx += x[i] * t[i];
                tkvadrat += Math.Pow(t[i], 2);
            }
            double akoef = 0, bkoef = 0, res = 0;
            if (tsum % t.Length == 0)
            {
                double koef = tsum / t.Length;
                akoef = tsum * koef;
                bkoef = t.Length * koef;
                res = xsum * koef;
            }
            double resa = tkvadrat - akoef;
            double a = (tx - res) / resa;

            double b = (tsum * a - xsum) / (-t.Length);

            double[] f = new double[8];
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = (i + 1) * a + b;
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < t.Length; i++)
            {
                chart1.Series[0].Points.AddXY(t[i], f[i]);
                chart1.Series[1].Points.AddXY(t[i], x[i]);
            }
            chart1.Series[0].Points.AddXY(t.Length + 1, f[7]);
        }
    }
}
