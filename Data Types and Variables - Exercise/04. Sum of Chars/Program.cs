using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char currentCh = char.Parse(Console.ReadLine());
                sumOfChars += (int)currentCh;
            }

            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
