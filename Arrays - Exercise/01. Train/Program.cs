using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] passengers = new int[n];

            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}
