﻿
namespace IILab5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkRadioButton1 = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton2 = new DarkUI.Controls.DarkRadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.t_d = new DarkUI.Controls.DarkTextBox();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkRadioButton3 = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton4 = new DarkUI.Controls.DarkRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(39, 128);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(100, 23);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "Пуск";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(39, 13);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(100, 20);
            this.darkTextBox1.TabIndex = 1;
            this.darkTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.darkTextBox1_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(220, 38);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(10, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "-";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(220, 61);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(10, 13);
            this.darkLabel2.TabIndex = 4;
            this.darkLabel2.Text = "-";
            // 
            // darkRadioButton1
            // 
            this.darkRadioButton1.Checked = true;
            this.darkRadioButton1.Location = new System.Drawing.Point(15, 36);
            this.darkRadioButton1.Name = "darkRadioButton1";
            this.darkRadioButton1.Size = new System.Drawing.Size(110, 17);
            this.darkRadioButton1.TabIndex = 6;
            this.darkRadioButton1.TabStop = true;
            this.darkRadioButton1.Text = "sin (x) + sin (x^2)";
            // 
            // darkRadioButton2
            // 
            this.darkRadioButton2.AutoSize = true;
            this.darkRadioButton2.Location = new System.Drawing.Point(15, 59);
            this.darkRadioButton2.Name = "darkRadioButton2";
            this.darkRadioButton2.Size = new System.Drawing.Size(103, 17);
            this.darkRadioButton2.TabIndex = 7;
            this.darkRadioButton2.Text = "x^4 - 6x^3 + 12x";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 157);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(907, 216);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(193, 15);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(22, 13);
            this.darkLabel4.TabIndex = 10;
            this.darkLabel4.Text = "t = ";
            // 
            // t_d
            // 
            this.t_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_d.Location = new System.Drawing.Point(220, 13);
            this.t_d.Name = "t_d";
            this.t_d.Size = new System.Drawing.Size(100, 20);
            this.t_d.TabIndex = 9;
            this.t_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.darkTextBox1_KeyPress);
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(326, 15);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(114, 13);
            this.darkLabel5.TabIndex = 11;
            this.darkLabel5.Text = "( по умолчанию: 100 )";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(12, 15);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(27, 13);
            this.darkLabel6.TabIndex = 12;
            this.darkLabel6.Text = "x0 =";
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(193, 38);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(21, 13);
            this.darkLabel7.TabIndex = 13;
            this.darkLabel7.Text = "x =";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(152, 61);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(62, 13);
            this.darkLabel8.TabIndex = 14;
            this.darkLabel8.Text = "Итераций: ";
            // 
            // darkRadioButton3
            // 
            this.darkRadioButton3.AutoSize = true;
            this.darkRadioButton3.Location = new System.Drawing.Point(15, 82);
            this.darkRadioButton3.Name = "darkRadioButton3";
            this.darkRadioButton3.Size = new System.Drawing.Size(145, 17);
            this.darkRadioButton3.TabIndex = 15;
            this.darkRadioButton3.Text = "100(y - x^2)^2 + (1 + x)^2";
            // 
            // darkRadioButton4
            // 
            this.darkRadioButton4.AutoSize = true;
            this.darkRadioButton4.Location = new System.Drawing.Point(15, 105);
            this.darkRadioButton4.Name = "darkRadioButton4";
            this.darkRadioButton4.Size = new System.Drawing.Size(79, 17);
            this.darkRadioButton4.TabIndex = 16;
            this.darkRadioButton4.Text = "|x^2| + |y^3|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 378);
            this.Controls.Add(this.darkRadioButton4);
            this.Controls.Add(this.darkRadioButton3);
            this.Controls.Add(this.darkLabel8);
            this.Controls.Add(this.darkLabel7);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.t_d);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.darkRadioButton2);
            this.Controls.Add(this.darkRadioButton1);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkButton1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "iIILab7";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkRadioButton darkRadioButton1;
        private DarkUI.Controls.DarkRadioButton darkRadioButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkTextBox t_d;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkRadioButton darkRadioButton3;
        private DarkUI.Controls.DarkRadioButton darkRadioButton4;
    }
}

