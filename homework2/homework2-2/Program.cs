using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 1, 4, 7, 6, 3 };
            int max = array[0], min = array[0], sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if(array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            double average = (double)sum / array.Length;
            System.Console.Write("最大值：" + max + "最小值：" + min + "平均值：" + average + "元素之和：" + sum);
        }
    }
}
