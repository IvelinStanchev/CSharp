/*Write a program that reads a string from the console and prints all different letters in the string along with information 
 how many times each letter is found. */
using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        char[] specialSigns = { ' ', '?', '!', ';', ',', '\n', '\t', '\r', '.', '-', '_', '[', ']', '{', '}', '^', '&', '@', '#', '$', '%', '*', };
        string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();
        string[] textWithoutSigns = text.Split(specialSigns);
        int[] repeatingCounter = new int[26];
        char[] allLeters = new char[26];

        int counter = 0;
        for (char i = 'a'; i <= 'z'; i++)//I am getting all letters
        {
            allLeters[counter] = i;
            counter++;
        }

        foreach (var word in textWithoutSigns)
        {
            char[] wordAsChar = word.ToCharArray();
            for (int i = 0; i < wordAsChar.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (wordAsChar[i] == allLeters[j])
                    {
                        repeatingCounter[j]++;
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < 26; i++)
        {
            Console.WriteLine("'" + allLeters[i] + "'" + " -> " + repeatingCounter[i]);
        }
    }
}
