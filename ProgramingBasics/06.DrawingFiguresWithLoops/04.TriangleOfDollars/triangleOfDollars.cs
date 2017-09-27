using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleOfDollars
{
    class triangleOfDollars
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine()); ;

            for (int row = 1; row <= side; row++)
            {
                Console.Write("$");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
