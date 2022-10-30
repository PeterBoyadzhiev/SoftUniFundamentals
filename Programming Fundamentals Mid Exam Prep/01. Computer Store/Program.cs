using System;
using System.Collections.Generic;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;

            while (input != "special" && input != "regular")
            {
                if (decimal.Parse(input) >= 0)
                {
                    decimal partPrice = decimal.Parse(input);
                    totalPrice += partPrice;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                input = Console.ReadLine();
            }

            decimal tax = totalPrice * 0.2m;
            decimal finalPrice = 0;

            if (input == "special")
            {
                finalPrice = (totalPrice + tax) * 0.9m;
            }
            else if (input == "regular")
            {
                finalPrice = totalPrice + tax;
            }

            if (finalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
