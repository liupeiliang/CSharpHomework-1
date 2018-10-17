using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x1 - leng / 2 * Math.Cos(th);
            double y2 = y1 - leng / 2 * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            if (comboBox1.Text == "Black")
                graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
            else if (comboBox1.Text == "Green")
                graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
            else if (comboBox1.Text == "Red")
                graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
            else if (comboBox1.Text == "Yellow")
                graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int lenth = trackBar1.Value;
            per1 = lenth / 10.0;
            per2 = lenth / 10.0;
            graphics.Clear(Color.White);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            string st = textBox1.Text;
            double degree = 30;
            try
            {
                degree = Convert.ToDouble(st);
            }
            catch(FormatException)
            {
            }
            th1 = degree * Math.PI / 180;
            th2 = (degree - 10) * Math.PI / 180;
        }
    }
}
