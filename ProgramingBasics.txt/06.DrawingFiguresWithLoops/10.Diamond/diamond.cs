using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int star = 1;
            int dash = (n - star) / 2;
            if (n % 2 == 0)
            {
                star = 2;
            }
            int countOfMiddleDashes = star;
            if (n < 3)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', star));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', star));

                for (int row = 0; row < (n - 1) / 2; row++)
                {
                    dash--;
                    Console.Write("{0}*{1}*{0}", new string('-', dash), new string('-', countOfMiddleDashes));
                    Console.WriteLine();
                    countOfMiddleDashes += 2;
                }
                countOfMiddleDashes -= 2;
                for (int row = 0; row < ((n + 1) / 2) - 2; row++)
                {
                    countOfMiddleDashes -= 2;
                    dash++;
                    Console.Write("{0}*{1}*{0}", new string('-', dash), new string('-', countOfMiddleDashes));
                    Console.WriteLine();

                }
                dash++;
                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', star));
            }
        }
    }
}
