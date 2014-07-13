/*Write a program that creates an array containing all letters from the alphabet (A-Z). 
 Read a word from the console and print the index of each of its letters in the array.*/
using System;

class AZLettersInArray
{
    static void Main()
    {
        char[] alphabet = new char[26];
        Console.Write("Enter a word : ");
        string word = Console.ReadLine();
        
        //Putting the letters in an array

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 97);
        }

        Console.Write("The indexes are: ");
        for (int i = 0; i < word.Length; i++)//I guess that the code is understandable
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write(j + " ");
                }
            }
        }
        Console.WriteLine();
    }
}
