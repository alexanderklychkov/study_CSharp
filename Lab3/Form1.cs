using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения Х
            double x = double.Parse(textBox2.Text);
            // Вывод значения Х в окно
            textBox1.Text = "x = " + x.ToString();
            // Считывание значения Y
            double m = double.Parse(textBox4.Text);
            // Вывод значения Y в окно
            textBox1.Text += Environment.NewLine + "m = " + m.ToString();

            double j;

            if (m > -1 && m < x)
            {
                j = Math.Sin(5 * Math.Pow(x, 2) + 3 * m * Math.Abs(Math.Pow(x, 2)));
            }
            else
            {
                if(x > m)
                {
                    j = Math.Cos(3 * Math.Pow(x, 2) + 5 * m * Math.Abs(Math.Pow(x, 2)));
                }
                else
                {
                    j = Math.Pow(Math.Pow(x, 2) + m, 2);
                }
            }

            textBox1.Text += Environment.NewLine + "Результат = " + j.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
        }
    }
}
