using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MatrixCreator(number);
        }

        private static void MatrixCreator(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int columns = 1; columns <= number; columns++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
