using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            

            while (array.Length > 1)
            {
                int[] condensed = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    
                    condensed[i] = array[i] + array[i + 1];
                    array[i] = condensed[i];
                    
                }

                array = condensed;
            }
            if (array[0] == 1)
            {
                Console.WriteLine("1 is already condensed to number");
            }
            else
            {
                Console.WriteLine(array[0]);
            }
            
        }
    }
}
