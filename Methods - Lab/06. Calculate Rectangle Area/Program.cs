using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double area = CalculateArea(number1, number2);
            Console.WriteLine(area);
        }

        private static double CalculateArea(double number1, double number2)
        {
            double area = number1 * number2;
            return area;
        }
    }
}
