using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int fibonaciNum = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;

            for (int row = 0; row < fibonaciNum; row++)
            {
                int newB = a + b;
                a = b;
                b = newB;
            }
            Console.WriteLine(a);
        }
    }
}
