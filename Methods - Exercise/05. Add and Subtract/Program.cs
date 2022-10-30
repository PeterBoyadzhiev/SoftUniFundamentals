using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            int inputThree = int.Parse(Console.ReadLine());
            int sum = SumOfNumbers(inputOne, inputTwo);
            int difference = Difference(sum, inputThree);
            Console.WriteLine(difference);

        }

        static int SumOfNumbers(int inputOne, int inputTwo)
        {
            int sum = inputOne + inputTwo;
            return sum;
        }
        static int Difference(int sum, int subtractor)
        {
            int difference = sum - subtractor;
            return difference;
        }
    }
}
