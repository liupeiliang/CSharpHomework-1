using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("输入一个整数：");
            try
            {
                int originalNumber = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("素数因子有：\n" );
                for (int i = 2; i < originalNumber; i++)
                {
                    if(originalNumber % i == 0)
                    {
                        System.Console.Write(i + "\n");
                        originalNumber = originalNumber / i;
                    }
                }
                System.Console.Write(originalNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
