using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int intOne = int.Parse(Console.ReadLine());
                int intTwo = int.Parse(Console.ReadLine());
                int result = GetMax(intOne, intTwo);
                Console.WriteLine(result);
            }
            else if (input == "string")
            {
                string stringOne = Console.ReadLine();
                string stringTwo = Console.ReadLine();
                string result = GetMax(stringOne, stringTwo);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char charOne = char.Parse(Console.ReadLine());
                char charTwo = char.Parse(Console.ReadLine());
                char result = GetMax(charOne, charTwo);
                Console.WriteLine(result);
            }
        }

        private static int GetMax(int intOne, int intTwo)
        {
            if (intOne > intTwo)
            {
                return intOne;
            }

            return intTwo;
        }

        private static string GetMax(string stringOne, string stringTwo)
        {
            int result = stringOne.CompareTo(stringTwo);

            if (result > 0)
            {
                return stringOne;
            }

            return stringTwo;
        }

        private static char GetMax(char charOne, char charTwo)
        {
            if (charOne > charTwo)
            {
                return charOne;
            }

            return charTwo;
        }
    }
}
