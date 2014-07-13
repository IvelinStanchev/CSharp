/*Write a program that reads a string from the console and lists all different words in the string along with information 
 how many times each word is found.*/
using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        char[] specialSigns = { ' ', '?', '!', ';', ',', '\n', '\t', '\r', '.', '-', '_', '[', ']', '{', '}', '^', '&', '@', '#', '$', '%', '*', };
        string text = "hey, hey csharp,program!orange?academy, hey,hey, program hey.academy";
        string[] textWithoutSpecialSigns = text.Split(specialSigns);
        List<string> allWordsOfTheText = new List<string>();

        foreach (var word in textWithoutSpecialSigns)
        {
            if (word != "")
            {
                allWordsOfTheText.Add(word);
            }
        }

        List<string> seenWords = new List<string>();
        int counter = 1;
        bool isSeen = false;

        //Now I will check how many times each word is found
        for (int i = 0; i < allWordsOfTheText.Count - 1; i++)
        {
            seenWords.Add(allWordsOfTheText[i]);
            for (int h = seenWords.Count - 2; h >= 0; h--)
            {
                if (allWordsOfTheText[i] == seenWords[h])//I check if the current word is seen in the List before it
                {
                    isSeen = true;
                }
            }

            if (isSeen == false)
            {
                for (int j = i + 1; j < allWordsOfTheText.Count; j++)
                {
                    if (allWordsOfTheText[i] == allWordsOfTheText[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine(allWordsOfTheText[i] + " -> " + counter);
            }

            isSeen = false;
            counter = 1;
        }
    }
}
