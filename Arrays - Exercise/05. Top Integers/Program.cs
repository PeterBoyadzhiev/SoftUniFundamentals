using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            

            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] <= array[k])
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger == true)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
