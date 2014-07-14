/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/
using System;

class Program
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (secondNumber > firstNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }

    static void Main()
    {
        Console.Write("Enter a first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
    }
}
