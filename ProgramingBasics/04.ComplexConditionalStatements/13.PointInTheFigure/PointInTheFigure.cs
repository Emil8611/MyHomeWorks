using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isOnBorder =
                (x == 0 && y > 0 && y <= h) ||
                (x == h && y >= h && y <= 4 * h) ||
                (x == 2 * h && y >= h && y <= 4 * h) ||
                (x == 3 * h && y >= 0 && y <= h) ||
                (x >= h && x <= 2 * h && y == 4 * h) ||
                (x >= 0 && x <= h && y == h) ||
                (x >= 2 * h && x <= 3 * h && y == h) ||
                (x >= 0 && x <= 3 * h && y == 0);

            bool isInRectangles =
                (x > 0 && x < 3 * h && y > 0 && y < h) ||
                (x > h && x < 2 * h && y > 0 && y < 4 * h);

            if (isOnBorder)
            {
                Console.WriteLine("border");
            }
            else if (isInRectangles)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
