/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */
using System;

class NumbersNSum
{
    static void Main()
    {
        Console.Write("Enter the amount of numbers you want to import: ");
        int amountNumbers = int.Parse(Console.ReadLine());

        int sum = 0;
        int number;

        Console.WriteLine("Enter {0} number: ", amountNumbers);
        for (int i = 0; i < amountNumbers; i++)
        {
            number = int.Parse(Console.ReadLine());//Enters a number
            sum += number;//Collects each number in 'sum' variable
        }
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

