using System;

namespace _1._ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {

                string city = Console.ReadLine();
                double moneyEarned = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 != 0)
                {
                    expenses *= 1.5;
                }
                else if (i % 5 == 0)
                {
                    moneyEarned *= 0.9;
                }
                double cityProfit = moneyEarned - expenses;

                totalProfit += cityProfit;

                Console.WriteLine($"In {city} Burger Bus earned {cityProfit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
