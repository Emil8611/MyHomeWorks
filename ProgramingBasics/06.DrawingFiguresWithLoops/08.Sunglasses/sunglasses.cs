using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            Console.WriteLine();

            for (int row = 0; row < n - 2; row++)
            {
                if (row == (n - 1) / 2 - 1)
                {
                    Console.Write("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
                    Console.WriteLine();
                }
            }


            Console.Write("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            Console.WriteLine();
        }
    }
}
