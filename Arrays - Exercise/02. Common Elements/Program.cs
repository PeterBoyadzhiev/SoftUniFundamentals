using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");
            string[] inputTwo = Console.ReadLine()
                .Split(" ");
            for (int i = 0; i < inputTwo.Length; i++)
            {
                for (int l = 0; l < input.Length; l++)
                {
                    if (input[l] == inputTwo[i])
                    {
                        Console.Write($"{input[l]} ");
                    }
                }
            }
        }
    }
}
