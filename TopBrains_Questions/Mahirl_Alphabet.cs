using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Read inputs
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        // Convert second word characters to a HashSet for fast lookup (case-insensitive)
        HashSet<char> secondWordChars = new HashSet<char>();
        foreach (char c in secondWord.ToLower())
        {
            secondWordChars.Add(c);
        }

        // Task 1: Remove common consonants
        StringBuilder filtered = new StringBuilder();
        foreach (char c in firstWord)
        {
            char lowerChar = char.ToLower(c);

            if (IsVowel(lowerChar))
            {
                // Always keep vowels
                filtered.Append(c);
            }
            else
            {
                // Keep consonant only if it does NOT appear in second word
                if (!secondWordChars.Contains(lowerChar))
                {
                    filtered.Append(c);
                }
            }
        }

        // Task 2: Remove consecutive duplicate characters (case-insensitive)
        StringBuilder result = new StringBuilder();
        char? previous = null;

        foreach (char c in filtered.ToString())
        {
            if (previous == null || char.ToLower(c) != char.ToLower(previous.Value))
            {
                result.Append(c);
                previous = c;
            }
        }

        // Output result
        Console.WriteLine(result.ToString());
    }

    static bool IsVowel(char c)
    {
        return "aeiou".IndexOf(c) != -1;
    }
}
