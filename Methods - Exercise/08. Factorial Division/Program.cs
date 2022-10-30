using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double factorial1 = Factorial(number1);
            double factorial2 = Factorial(number2);
            double division = Division(factorial1, factorial2);

            Console.WriteLine($"{division:f2}");
        }

        static double Factorial(int numberOne)
        {
            double factorial = 1;

            if (numberOne == 0)
            {
                factorial = 1;
            }
            else
            {
                for (int i = 1; i <= numberOne; i++)
                {
                    factorial *= i;
                }
            }
            
            return factorial;
        }

        static double Division(double divident, double divider)
        {
            double division = divident / divider;
            return division;
        }
    }
}
