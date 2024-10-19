namespace lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.x5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.x6 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.x7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Прогнозоване значення";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Фактичне значення";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(757, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.x7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.t7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.x6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.t6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.x5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.t5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.x4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.t4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.x3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.t3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.x2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.t2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.x1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.t1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(147, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 294);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "t";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "x";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(3, 39);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 2;
            this.t1.Text = "1";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(253, 39);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 3;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(3, 75);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 4;
            this.t2.Text = "2";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(253, 75);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 5;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(3, 111);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 20);
            this.t3.TabIndex = 6;
            this.t3.Text = "3";
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(253, 111);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(100, 20);
            this.x3.TabIndex = 7;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(3, 147);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 20);
            this.t4.TabIndex = 8;
            this.t4.Text = "4";
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(253, 147);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(100, 20);
            this.x4.TabIndex = 9;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(3, 183);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 20);
            this.t5.TabIndex = 10;
            this.t5.Text = "5";
            // 
            // x5
            // 
            this.x5.Location = new System.Drawing.Point(253, 183);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(100, 20);
            this.x5.TabIndex = 11;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(3, 219);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(100, 20);
            this.t6.TabIndex = 12;
            this.t6.Text = "6";
            // 
            // x6
            // 
            this.x6.Location = new System.Drawing.Point(253, 219);
            this.x6.Name = "x6";
            this.x6.Size = new System.Drawing.Size(100, 20);
            this.x6.TabIndex = 13;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(3, 255);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(100, 20);
            this.t7.TabIndex = 14;
            this.t7.Text = "7";
            // 
            // x7
            // 
            this.x7.Location = new System.Drawing.Point(253, 255);
            this.x7.Name = "x7";
            this.x7.Size = new System.Drawing.Size(100, 20);
            this.x7.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox x7;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox x6;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox x5;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

