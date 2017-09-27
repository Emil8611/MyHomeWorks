using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EvenPowerOf2
{
    class evenPowersOf2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int promenliva = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(promenliva);
                promenliva *= 4;
            }
        }
    }
}
