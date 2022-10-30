using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(columns + " ");
                }

                Console.WriteLine();
            }

            for (int rows = number - 1; rows >= 1; rows--)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(columns + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
