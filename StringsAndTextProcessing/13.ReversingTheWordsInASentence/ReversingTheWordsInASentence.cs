/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!"*/
using System;
using System.Text;

class ReversingTheWordsInASentence
{
    static void Main()
    {
        //Console.Write("Enter your sentence: ");
        //string sentence = Console.ReadLine();
        string sentence = "C# is not C++, not PHP and not Delphi!";

        string reversedSentence = ReversingTheSentence(sentence);
        Console.WriteLine(reversedSentence);
    }

    private static string ReversingTheSentence(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);//I am getting the words without the signs
        string[] signs = sentence.Split(words, StringSplitOptions.RemoveEmptyEntries);//I am getting the signs without the words

        Array.Reverse(words);//I reverse the sentence without the signs

        StringBuilder reversedSentence = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            reversedSentence.Append(words[i] + signs[i]);//I am making the new sentence
        }
        return reversedSentence.ToString();
    }
}
