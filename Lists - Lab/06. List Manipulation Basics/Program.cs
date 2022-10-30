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

            while (input != "end")
            {
                string[] inputDirections = input.Split();
                string command = inputDirections[0];

                if (command == "Add")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.Add(value);

                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    int value = int.Parse(inputDirections[1]);
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputDirections[1]);
                    int index = int.Parse(inputDirections[2]);
                    numbers.Insert(index, value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
