﻿using System;

namespace FinalCapitalOfSavingsConsApp
{
    class FinalCapitalCalculator
    {
        private const int InvestmentPeriodYears = 3;

        public double GetFinalCapital()
        {
            var initialCapital = GetInitialCapital();
            var interestRate = GetInterestRate();
            return CalcFinalCapital(initialCapital, interestRate, InvestmentPeriodYears);
        }

        double CalcFinalCapital(double initialCapital, double interestRate, int investmentPeriodYears)
        {
            return initialCapital * Math.Pow(1 + interestRate / 100, investmentPeriodYears);
        }

        double GetInterestRate()
        {
            while (true)
            {
                Console.Write("Enter the interest rate: ");
                var input = Console.ReadLine();
                if (double.TryParse(input, out double interestRate))
                {
                    return interestRate;
                }
                Console.WriteLine("Invalid input. Please enter a valid number like 3.5");
            }
        }

        double GetInitialCapital()
        {
            while (true)
            {
                Console.Write("Enter the initial capital: ");
                var input = Console.ReadLine();
                if (double.TryParse(input, out double capital))
                {
                    return capital;
                }
                Console.WriteLine("Invalid input. Please enter a valid number like 100.5");
            }
        }
    }
}
