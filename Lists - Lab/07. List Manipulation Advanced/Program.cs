using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            bool hasListBeenChanged = false;

            while (input != "end")
            {
                string[] inputDirections = input.Split();
                string command = inputDirections[0];

                if (command == "Add")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.Add(value);
                    hasListBeenChanged = true;
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.Remove(value);
                    hasListBeenChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.RemoveAt(value);
                    hasListBeenChanged = true;
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputDirections[1]);
                    int index = int.Parse(inputDirections[2]);
                    numbers.Insert(index, value);
                    hasListBeenChanged = true;
                }
                else if (command == "Contains")
                {
                    int value = int.Parse(inputDirections[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    int currentSum = numbers.Sum();
                    Console.WriteLine(currentSum);
                }
                else if (command == "Filter")
                {
                    string conditions = inputDirections[1];
                    int value = int.Parse(inputDirections[2]);

                    if (conditions == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (conditions == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > value)));
                    }
                    else if (conditions == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }
                    else if (conditions == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));
                    }

                }


                input = Console.ReadLine();
            }
            if (hasListBeenChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
