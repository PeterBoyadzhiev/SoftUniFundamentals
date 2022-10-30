using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if (command == "swap")
                {
                    int indexOne = int.Parse(commandArgs[1]);
                    int indexTwo = int.Parse(commandArgs[2]);
                    int currentNum = numbers[indexOne];
                    numbers[indexOne] = numbers[indexTwo];
                    numbers[indexTwo] = currentNum;
                }
                else if (command == "multiply")
                {
                    int indexOne = int.Parse(commandArgs[1]);
                    int indexTwo = int.Parse(commandArgs[2]);
                    numbers[indexOne] = numbers[indexOne] * numbers[indexTwo];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
