using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;

            if (input == "add")
            {
                result = AddMethod(a, b);
            }
            else if (input == "multiply")
            {
                result = MultiplyMethod(a, b);
            }
            else if (input == "divide")
            {
                result = Division(a, b);
            }
            else if (input == "subtract")
            {
                result = Subtraction(a, b);
            }

            Console.WriteLine(result);
        }

        private static double Subtraction(double numberOne, double numberTwo)
        {
            double subtraction = numberOne - numberTwo;
            return subtraction;
        }

        private static double Division(double numberOne, double numberTwo)
        {
            double division = numberOne / numberTwo;
            return division;
        }

        private static double MultiplyMethod(double numberOne, double numberTwo)
        {
            double multiplication = numberOne * numberTwo;
            return multiplication;
        }

        static double AddMethod(double numberOne, double numberTwo)
        {
            double sum = numberOne + numberTwo;
            return sum;
        }
    }
}
