using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double result = CalculateMathPow(number1, number2);
            Console.WriteLine(result);
        }

        private static double CalculateMathPow(double number1, double number2)
        {
            //double methodResult = Math.Pow(number1, number2);

            double methodResult = number1;

            for (int i = 1; i < number2; i++)
            {
                methodResult *= number1;
            }
            return methodResult;
        }
    }
}
