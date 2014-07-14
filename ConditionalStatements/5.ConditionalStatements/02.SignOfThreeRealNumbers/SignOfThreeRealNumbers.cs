/*Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
 Use a sequence of if statements.*/
using System;

class SignOfThreeRealNumbers
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if ((firstNumber == 0)|| (secondNumber == 0) || (thirdNumber == 0))
        {
            Console.WriteLine("The product has value 0 - > Doesn't have a sign");
        }
//first check with one sign ' - '
        else if ((firstNumber < 0) && ((secondNumber > 0) && (thirdNumber > 0)))
        {
            Console.WriteLine("The product has sign -> ' - '");
        }

        else if (((firstNumber > 0) && (secondNumber > 0)) && (thirdNumber < 0))
        {
            Console.WriteLine("The product has sign -> ' - '");
        }

        else if (((firstNumber > 0) && (thirdNumber > 0)) && (secondNumber < 0))
        {
            Console.WriteLine("The product has sign -> ' - '");
        }
//second check with two signs ' - '
        else if (((firstNumber < 0) && (secondNumber < 0)) && (thirdNumber > 0))
        {
            Console.WriteLine("The product has sign -> ' + '");
        }

        else if (((firstNumber < 0) && (thirdNumber < 0)) && (secondNumber > 0))
        {
            Console.WriteLine("The product has sign -> ' + '");
        }

        else if (((secondNumber < 0) && (thirdNumber < 0)) && (firstNumber > 0))
        {
            Console.WriteLine("The product has sign -> ' + '");
        }
//third check with three signs ' - '
        else if (((firstNumber < 0) && (secondNumber < 0)) && (thirdNumber < 0))
        {
            Console.WriteLine("The product has sign -> ' - '");
        }

        else
        {
            Console.WriteLine("The sign of the product is -> ' + '");
        }
    }
}

