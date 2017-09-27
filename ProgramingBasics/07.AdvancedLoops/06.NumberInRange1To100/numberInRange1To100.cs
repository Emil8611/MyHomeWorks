using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberInRange1To100
{
    class numberInRange1To100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in range [0...100]");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The right number is : {0}", num);
        }
    }
}
