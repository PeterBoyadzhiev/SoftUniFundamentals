using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;

            while (numberCopy > 0)
            {
                int currentDigit = numberCopy % 10;
                sum += currentDigit;
                numberCopy /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
