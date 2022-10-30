using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine = int.Parse(Console.ReadLine());

            int[] liftSpaces = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < liftSpaces.Length; i++)
            {
                while (liftSpaces[i] < 4)
                {

                    if (peopleInLine > 0)
                    {
                        liftSpaces[i]++;
                        peopleInLine--;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            if (peopleInLine == 0 && liftSpaces.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftSpaces));
            }
            else if (peopleInLine > 0 && !liftSpaces.Any(x => x < 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleInLine} people in a queue!");
                Console.WriteLine(string.Join(" ", liftSpaces));
            }
            else if (peopleInLine == 0 && !liftSpaces.Any(x => x < 4))
            {
                Console.WriteLine(string.Join(" ", liftSpaces));
            }
            
        }
    }
}
