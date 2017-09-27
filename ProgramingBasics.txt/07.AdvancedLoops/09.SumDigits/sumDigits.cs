using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    class sumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                int lastDigit = n % 10;
                n = n / 10;
                sum = sum + lastDigit;

            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
