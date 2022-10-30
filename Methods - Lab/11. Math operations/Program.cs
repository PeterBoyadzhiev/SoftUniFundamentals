using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            char calculationOperator = char.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double result = Operations(numberOne, calculationOperator, numberTwo);

            Console.WriteLine(result);
        }

        static double Operations(double numberOne, char calculationOperator , double numberTwo)
        {
            double result = 0;

            switch (calculationOperator)
            {
                case '+':
                    result = numberOne + numberTwo;
                    break;
                case '-':
                    result = numberOne - numberTwo;
                    break;
                case '*':
                    result = numberOne * numberTwo;
                    break;
                case '/':
                    result = numberOne / numberTwo;
                    break;
            }

            return result;
        }
    }
}
