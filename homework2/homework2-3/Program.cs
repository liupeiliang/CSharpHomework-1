using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i<=100; i++)
            {
                for(int j = 2; j <= i; j++)
                {
                    if (j == i)
                    {
                        System.Console.Write(i + "\n");
                    }
                    else if (i % j == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
