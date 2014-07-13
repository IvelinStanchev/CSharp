/*Write an expression that checks if given integer is odd or even.*/
using System;

class IntegerOddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number to check if the integer is odd or even: ");
        int numberInt = int.Parse(Console.ReadLine());
        if(numberInt % 2 ==0)
            Console.WriteLine("The number is even");
        else
            Console.WriteLine("The number is odd");
    }
}

