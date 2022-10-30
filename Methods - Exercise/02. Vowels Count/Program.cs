using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);

        }

        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;

            char[] vowels = new char[] { 'a', 'o', 'u', 'e', 'i' };

            foreach (char letter in text.ToLower())
            {
                if (ContainsVowels(vowels, letter))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;

        }

        static bool ContainsVowels(char[] array, char searchChar)
        {
            for (int i = 0; i < array.Length; i++)
            {
                char currCh = array[i];

                if (currCh == searchChar)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
