/*Write a program that reads two positive integer numbers and prints 
 how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.*/
using System;

class DivideBy5
{
    static void Main()
    {
        Console.Write("Enter the first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int keepFirstNumber = firstNumber;//That rows will help to reserve the first and second number in order
        int keepSecondNumber = secondNumber;//not to be changed after the 'if' condition

        int helpVariable;
        int count = 0;//This variable will help to count the numbers which could be divided by 5

        if (firstNumber > secondNumber)//If the first number is bigger than the second we exchange the values
        {
            helpVariable = firstNumber;
            firstNumber = secondNumber;
            secondNumber = helpVariable;
        }

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
                count++;
        }
        Console.WriteLine("p({0}, {1}) = {2}", keepFirstNumber, keepSecondNumber, count);
    }
}

