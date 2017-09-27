using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleOfNxNStars
{
    class RectangleOfNxNStars
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine()); ;

            for (int row = 1; row <= side; row++)
            {
                for (int col = 1; col <= side; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
