using System;
using System.Linq;

namespace _04._02_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < values.Length / 2; i++)
            {
                var temp = values[i];
                values[i] = values[values.Length - 1 - i];
                values[values.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(' ', values));
        }
    }
}
