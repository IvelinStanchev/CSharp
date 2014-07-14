/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/
using System;

class Palindromes
{
    public static bool IsPalindrome(string value)
    {
        bool isPalindrome = false;
        char[] symbols = value.ToCharArray();
        int length = symbols.Length / 2;// I divide the word in two parts
        string leftSide = "";
        string rightSide = "";

        for (int i = 0; i < length; i++)
        {
            leftSide += symbols[i].ToString();
        }

        if (length % 2 == 0)
        {
            for (int i = symbols.Length - 1; i >= length; i--)
            {
                rightSide += symbols[i];
            }
        }
        else
        {
            for (int i = symbols.Length - 1; i > length; i--)
            {
                rightSide += symbols[i];
            }
        }

        if (leftSide == rightSide)
        {
            isPalindrome = true;
        }
        else
        {
            isPalindrome = false;
        }
        return isPalindrome;
    }

    static void Main()
    {
        string text = "hello csharp exe,here is the bob phone caller!";
        string[] textWithoutSigns = text.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t', '\r', '.', '-', '_', '[', ']', '{', '}', }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in textWithoutSigns)
        {
            if (IsPalindrome(word) == true)
            {
                Console.WriteLine(word);
            }
        }
    }
}
