/*A dictionary is stored as a sequence of text lines containing words and their explanations. 
 Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
 .NET – platform for applications from Microsoft
 CLR – managed execution environment for .NET
 namespace – hierarchical organization of classes
 */
using System;

class WordsExplanation
{
    static void Main()
    {
        string[] wordsExplanation = { "platform for applications from Microsoft",
                                      "managed execution environment for .NET",
                                      "hierarchical organization of classes",
                                    };

        Console.Write("Enter a word ( .NET, CLR or namespace): ");
        string word = Console.ReadLine();
        string[] words = { ".NET", "CLR", "namespace" };

        int index = int.MinValue;
        index = PrintingTheExplanation(wordsExplanation, word, words, index);
    }

    private static int PrintingTheExplanation(string[] wordsExplanation, string word, string[] words, int index)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].IndexOf(word) == 0)//.IndexOf() returns 0 if the given string is found and -1 if it is not
            {
                index = i;
            }
        }
        if (index != int.MinValue)
        {
            Console.WriteLine(words[index] + " -> " + wordsExplanation[index]);
        }
        else
        {
            Console.WriteLine("The word {0} isn't containing in the dictionary", word);
        }
        return index;
    }
}
