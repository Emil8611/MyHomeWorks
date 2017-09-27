using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class enterEvenNumber
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number");
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }

            }
            Console.WriteLine("Even number entered : {0}", num);
        }
    }
}
