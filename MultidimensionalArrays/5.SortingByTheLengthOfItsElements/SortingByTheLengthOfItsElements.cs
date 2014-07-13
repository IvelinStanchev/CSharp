/*You are given an array of strings. Write a method that sorts the array by the length of its elements 
 (the number of characters composing them).*/
using System;
using System.Linq;

class SortingByTheLengthOfItsElements
{
    static void Main()
    {
        Console.Write("How many strings will you enter?: ");
        int length = int.Parse(Console.ReadLine());
        string[] array = new string[length];

        for (int i = 0; i < array.Length; i++)//Entering the strings
        {
            array[i] = Console.ReadLine();
        }

        var sortedSequence = array.OrderBy(x => x.Length);
        Console.WriteLine();
        foreach (var stringElement in sortedSequence)//Printing sorted the strings
        {
            Console.WriteLine(stringElement);
        }
    }
}
