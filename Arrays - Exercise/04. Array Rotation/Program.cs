using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int actualRotations = rotations % array.Length;

            for (int i = 0; i < actualRotations; i++)
            {
                int currNum = array[0];

                for (int k = 1; k < array.Length; k++)
                {
                    array[k - 1] = array[k];
                }

                array[array.Length - 1] = currNum;
            }


            Console.WriteLine(string.Join(" ", array));
        }
    }
}
