using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VolleyBall
{
    class VolleyBall
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var holidays = 48;
            var sofiaWeekends = (holidays - h) * 3 / 4;
            var sofiaGames = (p * 2) / 3;
            var sumGames = sofiaWeekends + h + sofiaGames;
            var leap = sumGames * 15 / 100;
            if (year == "leap")
            {
                Console.WriteLine(Math.Truncate(sumGames + leap));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(sumGames));
            }
        }
    }
}
