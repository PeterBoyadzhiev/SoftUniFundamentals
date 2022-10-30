using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Console.ReadLine();
            }
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(string.Join(" ", strings));
            }
        }
    }
}
