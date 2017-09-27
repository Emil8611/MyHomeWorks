using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USD =");
            var usd = double.Parse(Console.ReadLine());
            var bgn = 1.79549;
            var sum = usd * bgn;
            Console.WriteLine("BGN =" + Math.Round(sum, 2));
        }
    }
}
