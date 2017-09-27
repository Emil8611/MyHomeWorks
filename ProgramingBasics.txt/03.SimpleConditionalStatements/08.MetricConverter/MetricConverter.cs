using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double unit = double.Parse(Console.ReadLine());
            string inUnit = Console.ReadLine();
            string outUnit = Console.ReadLine();


            if (inUnit == "mm")
            {
                unit = unit / 1000;
            }
            if (inUnit == "cm")
            {
                unit = unit / 100;
            }
            if (inUnit == "mi")
            {
                unit = unit / 0.000621371192;
            }
            if (inUnit == "in")
            {
                unit = unit / 39.3700787;
            }
            if (inUnit == "km")
            {
                unit = unit / 0.001;
            }
            if (inUnit == "ft")
            {
                unit = unit / 3.2808399;
            }
            if (inUnit == "yd")
            {
                unit = unit / 1.0936133;
            }
            if (outUnit == "mm")
            {
                unit = unit * 1000;
            }
            if (outUnit == "cm")
            {
                unit = unit * 100;
            }
            if (outUnit == "mi")
            {
                unit = unit * 0.000621371192;
            }
            if (outUnit == "in")
            {
                unit = unit * 39.3700787;
            }
            if (outUnit == "km")
            {
                unit = unit * 0.001;
            }
            if (outUnit == "ft")
            {
                unit = unit * 3.2808399;
            }
            if (outUnit == "yd")
            {
                unit = unit * 1.0936133;
            }
            Console.WriteLine(unit + " " + outUnit);
        }
    }
}
