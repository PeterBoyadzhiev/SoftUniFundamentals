using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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


            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split();

                if (cmdArgs[0] == "Delete")
                {
                    int value = int.Parse(cmdArgs[1]);

                    numbers.RemoveAll(x => x == value);
                }
                else
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    numbers.Insert(index, value);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
