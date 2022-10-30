using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input != "END")
            {
                bool isPalindrome = PalindromeMethod(input);
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }


        }

        private static bool PalindromeMethod(string input)
        {
            int number = int.Parse(input);

            if (number > 0 && number < 10)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2 ; i++)
            {
                if (input[i] == input[input.Length - (i + 1)])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
