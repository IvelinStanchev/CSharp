/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/
using System;

class ListInAlphabeticalOrder
{
    static void Main()
    {
        char[] specialSigns = { ' ', '?', '!', ';', ',', '\n', '\t', '\r', '.', '-', '_', '[', ']', '{', '}', '^', '&', '@', '#', '$', '%', '*', };
        string text = "hey csharp program string main list alphabetical order orange academy";
        string[] textWithoutSpaces = text.Split(specialSigns);
        Array.Sort(textWithoutSpaces);

        PrintingTheSortedText(textWithoutSpaces);
    }

    private static void PrintingTheSortedText(string[] textWithoutSpaces)
    {
        foreach (var word in textWithoutSpaces)
        {
            Console.WriteLine(word);
        }
    }
}
