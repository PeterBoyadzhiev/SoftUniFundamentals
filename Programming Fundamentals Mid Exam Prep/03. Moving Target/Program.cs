using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);
                int value = int.Parse(commandArgs[2]);

                if (command == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        if (targets[index] - value <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        else
                        {
                            targets[index] = targets[index] - value;
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int startingIndex = index - value;
                    int endingIndex = index + value;

                    if ((index >= 0 && index < targets.Count)
                        && (startingIndex >= 0 && startingIndex < targets.Count)
                        && (endingIndex >= 0 && endingIndex < targets.Count))
                    {
                        targets.RemoveRange(startingIndex, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine(string.Join("|", targets));
        }
    }
}
