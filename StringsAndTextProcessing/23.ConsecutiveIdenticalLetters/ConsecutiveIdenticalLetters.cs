/*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
 Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".*/
using System;
using System.Collections.Generic;

class ConsecutiveIdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        List<string> wordWithoutRepeatingLetters = new List<string>();
        wordWithoutRepeatingLetters.Add(text[0].ToString());

        GettingTheSequenceOfNonIdenticalLetters(text, wordWithoutRepeatingLetters);

        PrintingTheSequence(wordWithoutRepeatingLetters);
    }

    private static void PrintingTheSequence(List<string> wordWithoutRepeatingLetters)
    {
        foreach (var letter in wordWithoutRepeatingLetters)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }

    private static void GettingTheSequenceOfNonIdenticalLetters(string text, List<string> wordWithoutRepeatingLetters)
    {
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])//If the current letter in not equal to the one before I add it to the List
            {
                wordWithoutRepeatingLetters.Add(text[i].ToString());
            }
        }
    }
}
