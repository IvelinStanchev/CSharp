/*Write a method that returns the last digit of given integer as an English word. 
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".*/
using System;

class LastDigitOfANumberAsWord
{
    static string[] digitsAsWord = new string[]{ "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    static int FindingLastDigitOfANumber(int number)
    {
        int lastDigit;
        lastDigit = number % 10;
        return lastDigit;
    }

    static void PrintingLastDigitAsWord(int lastDigit)
    {
        Console.WriteLine(digitsAsWord[lastDigit]);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int sayNumber = int.Parse(Console.ReadLine());
        if (sayNumber < 0)
        {
            sayNumber *= -1;
        }

        int lastDigit;
        lastDigit = FindingLastDigitOfANumber(sayNumber);
        PrintingLastDigitAsWord(lastDigit);
    }
}
