using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexNotInRange(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else if (true)
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (IsIndexNotInRange(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    string direction = cmdArgs[1];
                    int positions = int.Parse(cmdArgs[2]);

                    if (direction == "left")
                    {
                        MoveLeft(numbers, positions);
                    }
                    else if (direction == "right")
                    {
                        MoveRight(numbers, positions);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsIndexNotInRange(List<int> numbers, int index)
        {
            return index < 0 || index >= numbers.Count;
        }

        private static void MoveLeft(List<int> numbers, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }

        private static void MoveRight(List<int> numbers, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
