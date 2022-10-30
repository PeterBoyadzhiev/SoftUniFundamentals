using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            var numbers = new List<int>();

            foreach (var array in arrays)
            {
                numbers.AddRange(array.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
