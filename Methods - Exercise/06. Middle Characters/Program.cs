﻿using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            MiddleCharacter(inputString);
        }

        static void MiddleCharacter(string text)
        {
            if (text.Length % 2 ==0)
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
