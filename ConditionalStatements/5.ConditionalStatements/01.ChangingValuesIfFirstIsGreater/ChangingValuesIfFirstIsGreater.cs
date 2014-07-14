/*Write an if statement that examines two integer variables and exchanges their values 
 if the first one is greater than the second one.*/
using System;

class ChangingValuesIfFirstIsGreater
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        int helpVariable;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("The first number is greater");
            helpVariable = firstNumber;
            firstNumber = secondNumber;
            secondNumber = helpVariable;
            Console.WriteLine("After exchanging the values are: ");
            Console.WriteLine();
            Console.WriteLine("First number: {0}", firstNumber);
            Console.WriteLine("Second number: {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("The first number isn't bigger than the first one");
        }
    }
}

