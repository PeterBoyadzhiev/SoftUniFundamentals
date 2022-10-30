using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChars = Console.ReadLine();
            int repeatNum = int.Parse(Console.ReadLine());

            PrintRepeatingString(randomChars, repeatNum);
        }

        static void PrintRepeatingString(string randomChars, int repeatNum)
        {
            for (int i = 1; i <= repeatNum; i++)
            {
                Console.Write(randomChars);
            }
        }
    }
}
