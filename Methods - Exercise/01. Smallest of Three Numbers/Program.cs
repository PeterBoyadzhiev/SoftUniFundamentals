using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int smallestNumber = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                inputNumber = int.Parse(Console.ReadLine());
                smallestNumber = FindSmallestNumber(inputNumber, smallestNumber);
            }

            Console.WriteLine(smallestNumber);
        }

        private static int FindSmallestNumber(int inputNumber, int smallestNumber)
        {
            if (inputNumber < smallestNumber)
            {
                smallestNumber = inputNumber;
            }

            return smallestNumber;
        }

    }
}
