using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class house
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char dash = '-';



            int countOfStars = 1;
            int countOfDashes = (n - countOfStars) / 2;

            if (n % 2 == 0)
            {
                countOfStars += 1;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                Console.Write("{0}{1}{0}", new string(dash, countOfDashes), new string(star, countOfStars));
                Console.WriteLine();
                countOfStars += 2;
                countOfDashes -= 1;
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|{0}|", new string('*', n - 2));
                Console.WriteLine();
            }
        }
    }
}
