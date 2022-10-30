using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool indexFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int k = i + 1; k < array.Length; k++)
                {
                    sumRight += array[k];
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += array[j];
                }

                if (sumLeft == sumRight)
                {
                    indexFound = true;
                    Console.WriteLine(i);
                }
            }

            if (indexFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
