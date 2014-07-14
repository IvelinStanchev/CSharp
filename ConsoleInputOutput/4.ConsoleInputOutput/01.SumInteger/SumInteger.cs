/*Write a program that reads 3 integer numbers from the console and prints their sum.*/
using System;

class SumInteger
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int sum;
        sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine(Environment.NewLine);//Adds new line
        Console.WriteLine("Their sum is: {0}", sum);
    }
}
