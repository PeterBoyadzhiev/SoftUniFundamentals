using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> ListOfNames = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                string name = command[0];

                if (command.Length == 3)
                {
                    if (ListOfNames.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    ListOfNames.Add(name);
                }
                else if (command.Length == 4)
                {
                    if (ListOfNames.Contains(name))
                    {
                        ListOfNames.Remove(name);
                        continue;
                    }

                    Console.WriteLine($"{name} is not in the list!");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,ListOfNames));
        }
    }
}
