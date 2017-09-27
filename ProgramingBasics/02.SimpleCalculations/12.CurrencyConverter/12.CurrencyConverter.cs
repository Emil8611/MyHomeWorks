﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyToConvert = decimal.Parse(Console.ReadLine());

            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            decimal firstRate = 0.0m;
            decimal secondRate = 0.0m;

            if (firstCurrency == "BGN")
            {
                firstRate = 1;
            }

            else if (firstCurrency == "USD")
            {
                firstRate = 1.79549m;
            }
            else if (firstCurrency == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if (firstCurrency == "GBP")
            {
                firstRate = 2.53405m;
            }
            if (secondCurrency == "BGN")
            {
                secondRate = 1;
            }
            else if (secondCurrency == "USD")
            {
                secondRate = 1.79549m;
            }
            else if (secondCurrency == "EUR")
            {
                secondRate = 1.95583m;
            }
            else if (secondCurrency == "GBP")
            {
                secondRate = 2.53405m;
            }
            decimal result = moneyToConvert * (firstRate / secondRate);

            Console.WriteLine("{0} {1} ", Math.Round(result, 2), secondCurrency);
        }
    }
}
