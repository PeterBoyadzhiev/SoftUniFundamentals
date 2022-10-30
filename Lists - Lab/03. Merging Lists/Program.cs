using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstSelection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondSelection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultingSelection = new List<int>();

            int smallerSelectionEnd = Math.Min(firstSelection.Count, secondSelection.Count);

            for (int i = 0; i < smallerSelectionEnd; i++)
            {
                resultingSelection.Add(firstSelection[i]);
                resultingSelection.Add(secondSelection[i]);
            }

            if (firstSelection.Count > secondSelection.Count)
            {
                for (int i = smallerSelectionEnd; i < firstSelection.Count; i++)
                {
                    resultingSelection.Add(firstSelection[i]);
                }
            }
            else if(secondSelection.Count > firstSelection.Count)
            {
                for (int i = smallerSelectionEnd; i < secondSelection.Count; i++)
                {
                    resultingSelection.Add(secondSelection[i]);
                }
            }

            

            Console.WriteLine(string.Join(" ", resultingSelection));
        }
    }
}
