using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class factorial
    {
        static void Main(string[] args)
        {
            int numFactoriel = int.Parse(Console.ReadLine());
            int factoriel = 1;

            do
            {
                factoriel = factoriel * numFactoriel;
                numFactoriel--;
            } while (numFactoriel > 1);
            Console.WriteLine(factoriel);
        }
    }
}
