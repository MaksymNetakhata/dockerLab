using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] w = {10, 30, 60};
            double[] x = {10, 6, 5, 11, 9, 8, 7, 0};
            double[] f = new double[6];
            double wsum = 10 + 30 + 60;
            for (int i = 0; i < f.Length; i++)
            {
                if(i==5)
                {
                    x[7] = f[4];
                }
                f[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    f[i] += (w[j] * x[j+i]);
                }
                f[i] = f[i] / wsum;
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0;i < f.Length;i++)
            {
                chart1.Series[0].Points.AddXY(i+4 ,f[i]);
                chart1.Series[1].Points.AddXY(i+1, x[i]);
            }
        }
    }
}
