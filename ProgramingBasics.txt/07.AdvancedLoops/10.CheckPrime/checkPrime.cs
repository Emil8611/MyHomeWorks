﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    class checkPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var prime = true;
            if (n <= 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
