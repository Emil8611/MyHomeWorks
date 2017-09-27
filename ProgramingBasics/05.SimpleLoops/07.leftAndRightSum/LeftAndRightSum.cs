using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.leftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSum = firstSum + num;
            }
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSum = secondSum + num;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = " + firstSum);
            }
            else
            {
                var diff = firstSum - secondSum;
                Console.WriteLine("No, diff = " + Math.Abs(diff));
            }
        }
    }
}
