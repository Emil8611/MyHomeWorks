using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RectangleOf10x10Stars
{
    class RectangleOf10x10Stars
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
