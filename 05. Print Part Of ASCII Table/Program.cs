using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int charIndexStart = int.Parse(Console.ReadLine());
            int charIndexEnd = int.Parse(Console.ReadLine());

            for (int i = charIndexStart; i <= charIndexEnd; i++)
            {

                char currentChar = (char)i;
                Console.Write($"{currentChar} ");
            }
        }
    }
}
