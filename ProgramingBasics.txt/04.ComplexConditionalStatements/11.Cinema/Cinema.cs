using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projektion = Console.ReadLine().ToLower();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());

            var price = 0d;
            var leva = 0d;

            if (projektion == "premiere")
            {
                price = 12;
            }
            else if (projektion == "normal")
            {
                price = 7.50;
            }
            else if (projektion == "discount")
            {
                price = 5;
            }
            leva = rows * cols * price;
            Console.WriteLine("{0:f2} leva", leva);

        }
    }
}
