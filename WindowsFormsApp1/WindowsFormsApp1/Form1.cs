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
            for(int i = 0; i < 5; i++)
{
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells[0].Value = "A";
            dataGridView1.Rows[1].Cells[0].Value = "B";
            dataGridView1.Rows[2].Cells[0].Value = "C";
            dataGridView1.Rows[3].Cells[0].Value = "D";
            dataGridView1.Rows[4].Cells[0].Value = "Вага критерію";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] a = new double[4, 4];
            a[0, 0] = double.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
            a[0, 1] = double.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
            a[0, 2] = double.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString());
            a[0, 3] = double.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());

            a[1, 0] = double.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString());
            a[1, 1] = double.Parse(dataGridView1.Rows[1].Cells[2].Value.ToString());
            a[1, 2] = double.Parse(dataGridView1.Rows[1].Cells[3].Value.ToString());
            a[1, 3] = double.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString());

            a[2, 0] = double.Parse(dataGridView1.Rows[2].Cells[1].Value.ToString());
            a[2, 1] = double.Parse(dataGridView1.Rows[2].Cells[2].Value.ToString());
            a[2, 2] = double.Parse(dataGridView1.Rows[2].Cells[3].Value.ToString());
            a[2, 3] = double.Parse(dataGridView1.Rows[2].Cells[4].Value.ToString());

            a[3, 0] = double.Parse(dataGridView1.Rows[3].Cells[1].Value.ToString());
            a[3, 1] = double.Parse(dataGridView1.Rows[3].Cells[2].Value.ToString());
            a[3, 2] = double.Parse(dataGridView1.Rows[3].Cells[3].Value.ToString());
            a[3, 3] = double.Parse(dataGridView1.Rows[3].Cells[4].Value.ToString());



            double[] w = new double[4];

            w[0] = double.Parse(dataGridView1.Rows[4].Cells[1].Value.ToString());
            w[1] = double.Parse(dataGridView1.Rows[4].Cells[2].Value.ToString());
            w[2] = double.Parse(dataGridView1.Rows[4].Cells[3].Value.ToString());
            w[3] = double.Parse(dataGridView1.Rows[4].Cells[4].Value.ToString());

            double wsum = w[0] + w[1] + w[2] + w[3];

            w[0] = w[0] / wsum;
            w[1] = w[1] / wsum;
            w[2] = w[2] / wsum;
            w[3] = w[3] / wsum;

            double[] k = new double[4];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = 1;
            }

            int[] minpos = new int[4];
            int[] maxpos = new int[4];
            double[] max = new double[4];
            double[] min = new double[4];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                max[i] = int.MinValue; min[i] = int.MaxValue;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[j, i] < min[i])
                    {
                        min[j] = (double)a[j, i];
                        minpos[j] = i;
                    }
                    if (a[j, i] > max[i])
                    {
                        max[j] = (double)a[j, i];
                        maxpos[j] = i;
                    }
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0 || j == 2)
                    {
                        a[i, j] = (a[i, maxpos[j]] - Math.Abs(a[i, j])) / (a[i, maxpos[j]] - a[i, minpos[j]]);       
                    }
                    else
                    {
                        a[i, j] = (Math.Abs(a[i, j]) - a[i, minpos[j]]) / (a[i, maxpos[j]] - a[i, minpos[j]]);
                    }   
                }
                
            }
            for(int i = 0;i < k.Length;i++)
            {
                for(int j = 0;j < 4;j++)
                {
                    k[i] *= Math.Pow(a[i, j], w[j]);
                }
            }
            string res = "";
            int pos = Array.IndexOf(k, k.Max()) + 1;
            if (pos == 1) { res = "Найкращий варіант - A, центр місті"; }
            if (pos == 2) { res = "Найкращий варыант - B, житловий сектор"; }
            if (pos == 3) { res = "Найкращий варыант - C, промислова зона"; }
            if (pos == 4) { res = "Найкращий варыант - D, на околицы міста"; }

            label1.Text = "Найвигідніший кандидат: " + res;

        }
    }
}
