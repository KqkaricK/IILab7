using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DarkUI.Forms;


namespace IILab5
{
    public partial class Form1 : DarkForm
    {
        Random rnd = new Random();
        double t;
        const double NACH_TEMPER = 100;
        public Form1()
        {
            InitializeComponent();
        }

        double Y(double x)
        {
            return Math.Sin(x*x)+Math.Sin(x);
        }
        double GreatRando(double x)
        {
            return x + (rnd.NextDouble() * 10) - 5;
        }
        double Ver(double t, double x0, double x1)
        {
            return Math.Pow(Math.E, (x1 - x0) / t);
        }
        double Temp(double t)
        {
            return t*0.97;
        }
        double Funk2(double x)
        {
            return x * x * x * x - 6 * x * x * x + 12 * x;
        }
        double Funk3(double x, double y)
        {
            return 100 * (y - (x * x)) * (y - (x * x)) + (1 + (x * x));
        }
        double Funk4(double x, double y)
        {
            return Math.Abs(x) * Math.Abs(x) + Math.Abs(y) * Math.Abs(y) * Math.Abs(y);
        }

        void Action1()
        {
            double x0 = Convert.ToDouble(darkTextBox1.Text);
            double x1 = GreatRando(x0);
            int i = 1;
            chart1.Series[0].Points.AddXY(i, x1);
            while (t > 0.1)
            {
                if (Y(x0) > Y(x1))
                {
                    x0 = x1;
                }
                else
                {
                    if (Ver(t, x0, x1) <= rnd.Next(0, 1))
                    {
                        x0 = x1;
                    }
                }
                t = Temp(t);
                i++;
                chart1.Series[0].Points.AddXY(i, x1);
                x1 = GreatRando(x0);
            }
            darkLabel1.Text = x0.ToString();
            darkLabel2.Text = i.ToString();
        }
        void Action2()
        {
            double x0 = Convert.ToDouble(darkTextBox1.Text);
            double x1 = GreatRando(x0);
            int i = 1;
            chart1.Series[0].Points.AddXY(i, x1);
            while (t > 0.1)
            {
                if (Funk2(x0) > Funk2(x1))
                {
                    x0 = x1;
                }
                else
                {
                    if (Ver(t, x0, x1) <= rnd.Next(0, 1))
                    {
                        x0 = x1;
                    }
                }
                t = Temp(t);
                i++;
                chart1.Series[0].Points.AddXY(i, x1);
                x1 = GreatRando(x0);
            }
            darkLabel1.Text = x0.ToString();
            darkLabel2.Text = i.ToString();
        }
        void Action3()
        {
            double x0 = Convert.ToDouble(darkTextBox1.Text);
            double y0 = Convert.ToDouble(darkTextBox1.Text);
            double x1 = GreatRando(x0);
            double y1 = GreatRando(x0);
            int i = 1;
            chart1.Series[0].Points.AddXY(i, x1);
            chart1.Series[1].Points.AddXY(i, y1);
            while (t > 0.1)
            {
                if (Funk3(x0, y0) > Funk3(x1, y1))
                {
                    x0 = x1;
                    y0 = y1;
                }
                else
                {
                    int tmp = rnd.Next(0, 1);
                    if ((Ver(t, x0, x1) <= tmp) && (Ver(t, y0, y1) <= tmp))
                    {
                        x0 = x1;
                        y0 = y1;
                    }
                }
                t = Temp(t);
                i++;
                chart1.Series[0].Points.AddXY(i, x1);
                chart1.Series[1].Points.AddXY(i, y1);
                x1 = GreatRando(x0);
                y1 = GreatRando(x0);
            }
            darkLabel1.Text = x0.ToString() + "  y = " + y0.ToString();
            darkLabel2.Text = i.ToString();
        }
        void Action4()
        {
            double x0 = Convert.ToDouble(darkTextBox1.Text);
            double y0 = Convert.ToDouble(darkTextBox1.Text);
            double x1 = GreatRando(x0);
            double y1 = GreatRando(x0);
            int i = 1;
            chart1.Series[0].Points.AddXY(i, x1);
            chart1.Series[1].Points.AddXY(i, y1);
            while (t > 0.1)
            {
                if (Funk4(x0, y0) > Funk4(x1, y1))
                {
                    x0 = x1;
                    y0 = y1;
                }
                else
                {
                    int tmp = rnd.Next(0, 1);
                    if ((Ver(t, x0, x1) <= tmp) && (Ver(t, y0, y1) <= tmp))
                    {
                        x0 = x1;
                        y0 = y1;
                    }
                }
                t = Temp(t);
                i++;
                chart1.Series[0].Points.AddXY(i, x1);
                chart1.Series[1].Points.AddXY(i, y1);
                x1 = GreatRando(x0);
                y1 = GreatRando(x0);
            }
            darkLabel1.Text = x0.ToString() + "  y = " + y0.ToString();
            darkLabel2.Text = i.ToString();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            t = NACH_TEMPER;
            if (t_d.Text != "")
                t = Convert.ToDouble(t_d.Text);
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            if (darkRadioButton1.Checked == true)
            {
                Action1();
            }
            else if (darkRadioButton2.Checked == true)
            {
                Action2();
            }
            else if (darkRadioButton3.Checked == true)
            {
                Action3();
            }
            else 
            {
                Action4();
            }
        }
        private void darkTextBox1_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 45 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void darkTextBox2_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        void Copyraight()
        {
            MessageBox.Show("   Created and Development by AK.\n« Нужный человек не в том месте может перевернуть мир. » \n                                                                           — Half Life 2");
        } 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                Copyraight();
            }
        }
    }
}
