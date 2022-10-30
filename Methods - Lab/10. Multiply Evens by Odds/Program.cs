using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));
            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());
            int multiply = GetMultipleOfEvenAndOdds(sumOfEvenDigits, sumOfOddDigits);
            Console.WriteLine(multiply);
        }

        private static int GetMultipleOfEvenAndOdds(int sumOfEvenDigits, int sumOfOddDigits)
        {
            int multiplication = sumOfEvenDigits * sumOfOddDigits;
            return multiplication;
        }

        private static int GetSumOfEvenDigits(string evenNumbers)
        {
            int sumEven = 0;

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                int currentNum = Math.Abs(int.Parse(evenNumbers[i].ToString()));

                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
            }

            return sumEven;

        }

        private static int GetSumOfOddDigits(string oddNumbers)
        {
            int sumOdd = 0;

            for (int i = 0; i < oddNumbers.Length; i++)
            {
                int currentNum = Math.Abs(int.Parse(oddNumbers[i].ToString()));

                if (currentNum % 2 == 1)
                {
                    sumOdd += currentNum;
                }
            }

            return sumOdd;
        }
    }
}
