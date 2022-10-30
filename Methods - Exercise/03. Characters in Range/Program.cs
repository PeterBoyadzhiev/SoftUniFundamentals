using System;
using System.Linq;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input characters

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            //method

            CharsInRange(firstChar, secondChar);
        }

        private static void CharsInRange(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
