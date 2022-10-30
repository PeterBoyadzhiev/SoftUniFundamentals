using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int water = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int addWater = int.Parse(Console.ReadLine());
                water += addWater;

                if (water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    water -= addWater;
                    continue;
                }
            }

            Console.WriteLine(water);
        }
    }
}
