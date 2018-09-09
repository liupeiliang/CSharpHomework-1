using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_作业1_输入两个数字计算乘积
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Num1, Num2, Result;
            string text;
            Num1 = Double.Parse(num1.Text);
            Num2 = Double.Parse(num2.Text);
            Result = Num1 * Num2;
            text = Result.ToString();
            result.Text = text;
        }
    }
}
