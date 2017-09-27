using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDagrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radians = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine("Degrees =" + Math.Round(deg, 2));
        }
    }
}
