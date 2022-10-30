using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;

                for (int k = i + 1; k < array.Length; k++)
                {
                    sum = array[i] + array[k];

                    if (sum == magicSum)
                    {
                        Console.WriteLine($"{array[i]} {array[k]}");
                    }
                }
            }
        }
    }
}
