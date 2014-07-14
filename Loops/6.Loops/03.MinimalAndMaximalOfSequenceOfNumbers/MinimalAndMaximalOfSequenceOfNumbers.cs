/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/
using System;

class MinimalAndMaximalOfSequenceOfNumbers
{
    static void Main()
    {
        Console.Write("How many numbers you want to enter: ");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numbers = new int [numberCount];
        int minimal, maximal;

        if (numberCount == 0)
        {
        Console.WriteLine("Re enter your number");
        }
        if (numberCount == 1)//If you must enter one number it shows 1 number not 1 numbers
        {
            Console.WriteLine("Enter {0} number: ", numberCount);
        }
        else
        {
            Console.WriteLine("Enter {0} numbers: ", numberCount);
        }

        for (int i = 0; i < numberCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        minimal = numbers[0];
        maximal = numbers[0];

        for (int h = 1; h < numberCount; h++)
        {
            if (numbers[h] < minimal)
            {
                minimal = numbers[h];
            }
            if (numbers[h] > maximal)
            {
                maximal = numbers[h];
            }
        }
        Console.WriteLine("The minimal number of all numbers is: {0}", minimal);
        Console.WriteLine("The maximal number of all numbers is: {0}", maximal);
    }
}

