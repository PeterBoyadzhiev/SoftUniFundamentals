using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            TopNumber(endNumber);
        }

        static void TopNumber(int endNumber)
        {
            bool isTopNumber = false;

            

            for (int i = 1; i <= endNumber; i++)
            {
                int reminder;
                int sum = 0;

                bool containsOddDigit = false;

                int currNum = i;
                while (currNum > 0)
                {
                    reminder = currNum % 10;
                    sum += reminder;
                    currNum /= 10;

                    if (reminder % 2 == 1)
                    {
                        containsOddDigit = true;
                    }
                }

                if (sum % 8 == 0 && containsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
