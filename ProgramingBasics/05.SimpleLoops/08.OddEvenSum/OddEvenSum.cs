using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + num;
                }
                else
                {
                    oddSum = oddSum + num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = {0} ", evenSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0} ", Math.Abs(evenSum - oddSum));
            }
        }
    }
}
