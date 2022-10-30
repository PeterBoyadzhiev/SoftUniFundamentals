using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double cost = PrintCost(product, quantity);

            Console.WriteLine($"{cost:f2}");
        }

        static double PrintCost(string product, int quantity)
        {
            double sum = 0;

            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    break;
                case "water":
                    sum = quantity * 1.00;
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    break;
            }

            return sum;
        }
    }
}
