/*Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
 I haven't used quicksort algorithm but mine (it will work for numbers too)*/
using System;

class SortingArrayOfString
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        char[] array = new char[word.Length];

        //Putting the letters in array

        for (int i = 0; i < word.Length; i++)
        {
            array[i] = word[i];
        }

        char helpVariable;//It will help me to exchange two chars

        //Rearranging the matrix

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (array[j] < array[i])
                {
                    helpVariable = array[i];
                    array[i] = array[j];
                    array[j] = helpVariable;
                }
            }
        }

        Console.Write("The sorted array: ");

        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
