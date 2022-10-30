using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();

            if (!ValidatePassRange(passwordInput))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ValidatePassSymbols(passwordInput))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ValidateDigits(passwordInput))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (ValidatePassRange(passwordInput) && ValidatePassSymbols(passwordInput) && ValidateDigits(passwordInput))
            {
                Console.WriteLine("Password is valid");
            }
            

        }

        static bool ValidatePassRange(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
        }

        static bool ValidatePassSymbols(string password)
        {
            foreach (char letter in password)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidateDigits(string password)
        {
            int digitsCount = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitsCount++;
                }
            }

            if (digitsCount < 2)
            {
                return false;
            }
            return true;
        }
    }
}
