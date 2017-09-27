using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var sum = 0d;
            var currentSum = 0d;
            var previousSum = 0d;
            var maxDiff = double.MinValue;
            var diff = 0d;

            for (int i = 0; i < n; i++)
            {
                previousSum = currentSum;
                currentSum = 0d;
                currentSum += double.Parse(Console.ReadLine());
                currentSum += double.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs(currentSum - previousSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
            if (previousSum == currentSum || n == 1)
            {
                Console.WriteLine("Yes, value= {0}", currentSum);
            }
            else
            {
                Console.WriteLine("No, maxDiff= {0}", maxDiff);
            }
        }
    }
}
