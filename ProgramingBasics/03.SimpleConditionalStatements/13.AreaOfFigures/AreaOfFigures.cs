using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                var area = a * h / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
