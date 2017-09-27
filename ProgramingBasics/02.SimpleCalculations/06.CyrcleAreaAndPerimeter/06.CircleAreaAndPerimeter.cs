using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter r : ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine(area);
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine(perimeter);
        }
    }
}
