using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arrThree = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = arrThree[0];
                    arrTwo[i] = arrThree[1];
                }
                else
                {
                    arrTwo[i] = arrThree[0];
                    arrOne[i] = arrThree[1];
                }
            }
            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
