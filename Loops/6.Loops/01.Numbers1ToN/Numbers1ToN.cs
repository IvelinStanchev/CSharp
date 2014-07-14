/*Write a program that prints all the numbers from 1 to N.*/
using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers in the range (1, {0}) are: ", number);
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

