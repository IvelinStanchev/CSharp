﻿/*We are given a string containing a list of forbidden words and a text containing some of these words. 
 Write a program that replaces the forbidden words with asterisks. Example:
  
 Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
 implemented as a dynamic language in CLR.
  
 Words: "PHP, CLR, Microsoft"
		The expected result:
 
 ********* announced its next generation *** compiler today. 
 It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
using System;

class ReplacingTheForbiddenWordsWithAsterisks
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = new string[3] { "PHP", "CLR", "Microsoft" };

        Console.WriteLine(ReplacingTheForbiddenWords(text, forbiddenWords));
    }

    private static string ReplacingTheForbiddenWords(string text, string[] forbiddenWords)
    {
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        return text;
    }
}
