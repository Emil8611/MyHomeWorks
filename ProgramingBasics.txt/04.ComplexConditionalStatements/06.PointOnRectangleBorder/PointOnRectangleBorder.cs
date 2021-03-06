﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool leftSide = x == x1 && y >= y1 && y <= y2;
            bool rightSide = x == x2 && y >= y1 && y <= y2;
            bool upSide = y == y1 && x >= x1 && x <= x2;
            bool downSide = y == y2 && x >= x1 && x <= x2;

            if (leftSide || rightSide || upSide || downSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
