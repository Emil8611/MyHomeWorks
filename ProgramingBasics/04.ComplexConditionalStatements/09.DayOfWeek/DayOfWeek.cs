﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
