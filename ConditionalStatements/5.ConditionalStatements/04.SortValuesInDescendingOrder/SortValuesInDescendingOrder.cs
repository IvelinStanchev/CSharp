/*Sort 3 real values in descending order using nested if statements.*/
using System;

class SortValuesInDescendingOrder
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int bigNumber;//The biggest number
        bigNumber = firstNumber;

        if (secondNumber > bigNumber)
        {
            bigNumber = secondNumber;
        }

        if (thirdNumber > bigNumber)
        {
            bigNumber = thirdNumber;
        }

        int smallNumber;//The smallest number
        smallNumber = firstNumber;
        
        if (secondNumber < smallNumber)
        {
            smallNumber = secondNumber;
        }

        if (thirdNumber < smallNumber)
        {
            smallNumber = thirdNumber;
        }

        int middleNumber;//The middle number
        middleNumber = firstNumber;

        if ((secondNumber > smallNumber) && (secondNumber < bigNumber))
        {
            middleNumber = secondNumber;
        }

        if ((thirdNumber > smallNumber) && (thirdNumber < bigNumber))
        {
            middleNumber = thirdNumber;
        }
        Console.WriteLine("The descending order of the three number is: ");
        Console.WriteLine();
        Console.WriteLine(new string(((char)18), 50));
        Console.WriteLine();
        Console.WriteLine(bigNumber);
        Console.WriteLine(middleNumber);
        Console.WriteLine(smallNumber);
    }
}

