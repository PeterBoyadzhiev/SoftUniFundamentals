using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            double[] arrayOfNumbers = new double [numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                arrayOfNumbers[i] = double.Parse(numbers[i]);
                Console.WriteLine($"{arrayOfNumbers[i]} => {(int)Math.Round(arrayOfNumbers[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
