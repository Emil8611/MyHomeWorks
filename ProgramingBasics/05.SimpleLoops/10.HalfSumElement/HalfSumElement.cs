using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var max = int.MinValue;
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > max)
                {
                    max = num;
                }
            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
