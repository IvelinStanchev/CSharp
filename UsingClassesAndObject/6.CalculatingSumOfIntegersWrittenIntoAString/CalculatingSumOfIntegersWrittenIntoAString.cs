/*You are given a sequence of positive integer values written into a string, separated by spaces. 
 Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318" -> result = 461*/
using System;

class CalculatingSumOfIntegersWrittenIntoAString
{
    static void Main()
    {
        Console.Write("Enter the sequence of numbers separated by space: ");
        string[] numbersWithSpace = Console.ReadLine().Split(' ');
        int numbersSum = 0;

        for (int i = 0; i < numbersWithSpace.Length; i++)
        {
            numbersSum += int.Parse(numbersWithSpace[i]);
        }
        Console.WriteLine("The sum is: {0}", numbersSum);
    }
} 
