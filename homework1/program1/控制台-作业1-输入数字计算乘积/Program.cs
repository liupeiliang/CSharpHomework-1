using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台_作业1_输入数字计算乘积
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("请输入第一个数字：");
            s = Console.ReadLine();
            num1 = Double.Parse(s);
            Console.WriteLine("请输入第二个数字：");
            s = Console.ReadLine();
            num2 = Double.Parse(s);
            Console.WriteLine(num1 + "*" + num2 + " = " + (num1 * num2));
        }
    }
}
