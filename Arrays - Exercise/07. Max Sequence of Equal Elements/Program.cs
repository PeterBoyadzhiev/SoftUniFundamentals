using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int tempCount = 1;
            int maxCount = 1;
            int number = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    number = array[i - 1];
                }
            }

            int[] arrayTwo = new int[maxCount];

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = number;
            }

            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}
