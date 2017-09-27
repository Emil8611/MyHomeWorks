using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var oddSum = 0d;
            var evenSum = 0d;

            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;

            for (int i = 1; i <= num; i++)
            {
                var n = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (n > evenMax)
                    {
                        evenMax = n;
                    }
                    if (n < evenMin)
                    {
                        evenMin = n;
                    }
                    evenSum = evenSum + n;
                }
                else
                {
                    if (n > oddMax)
                    {
                        oddMax = n;
                    }
                    if (n < oddMin)
                    {
                        oddMin = n;
                    }
                    oddSum = oddSum + n;
                }
            }
            Console.WriteLine("oddSum = {0}", oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("oddMin= No");
            }
            else
            {
                Console.WriteLine("oddMin = {0}", oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("oddMax = No");
            }
            else
            {
                Console.WriteLine("oddMax = {0}", oddMax);
            }
            Console.WriteLine("evenSum = {0}", evenSum);

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("evenMin = No");
            }
            else
            {
                Console.WriteLine("evenMin = {0}", evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("evenMax = No");
            }
            else
            {
                Console.WriteLine("evenMax = {0}", evenMax);
            }
        }
    }
}
