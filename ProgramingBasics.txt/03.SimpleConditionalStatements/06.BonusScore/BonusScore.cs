using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var bonus = 0d;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num <= 1000)
            {
                bonus = num * 20 / 100;
            }
            else if (num > 1000)
            {
                bonus = num * 10 / 100;
            }
            if (num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
