using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> game = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();

            int numberOfMoves = 0;

            while (input != "end")
            {
                numberOfMoves++;

                int[] commands = input.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int indexOne = commands[0];
                int indexTwo = commands[1];

                if (indexOne == indexTwo
                    || (indexOne < 0 || indexOne >= game.Count)
                        || (indexTwo < 0 || indexTwo >= game.Count))
                {
                    string toBeAdded = numberOfMoves.ToString();
                    game.Insert(game.Count / 2, $"-{toBeAdded}a");
                    game.Insert(game.Count / 2, $"-{toBeAdded}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (game[indexOne] == game[indexTwo])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {game[indexOne]}!");
                    game.RemoveAt(Math.Min(indexOne, indexTwo));
                    game.RemoveAt(Math.Max(indexOne, indexTwo) - 1);
                    
                }
                else if (game[indexOne] != game[indexTwo])
                {
                    Console.WriteLine("Try again!");
                }

                if (game.Count <= 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (game.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", game));
            }

        }
    }
}
