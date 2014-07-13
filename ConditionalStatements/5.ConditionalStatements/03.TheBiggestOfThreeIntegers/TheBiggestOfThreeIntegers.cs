/*Write a program that finds the biggest of three integers using nested if statements.*/
using System;

class TheBiggestOfThreeIntegers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int bigNumber;
        bigNumber = firstNumber;//We abstract the first number and with if-statements will check if it is bigger than the rest

        if (secondNumber > firstNumber)
        {
            bigNumber = secondNumber;
        }

        if (thirdNumber > firstNumber)
        {
            bigNumber = thirdNumber;
        }
        Console.WriteLine();
        Console.WriteLine("The biggest number is: {0}", bigNumber);
    }
}

