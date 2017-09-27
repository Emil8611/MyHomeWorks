using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahremheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsium = ");
            var celsium = double.Parse(Console.ReadLine());
            var farenhait = (celsium * 1.8) + 32;
            Console.WriteLine(" Farenhait = ");
            Console.WriteLine(Math.Round(farenhait, 2));
        }
    }
}
