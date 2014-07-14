/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).*/
using System;

class CheckingIfTheBracketsArePutCorrectly
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();
        bool isCorrect = true;
        int leftBrackets = 0;
        int rightBrackets = 0;

        if (expression[0] == ')')
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')//I get the number of left brackets
                {
                    leftBrackets++;
                }
                if (expression[i] == ')')//I get the number of right brackets
                {
                    rightBrackets++;
                }
            }
        }

        if (leftBrackets != rightBrackets)//If the number of right brackets isn't equal to the number of left brackets, then the expression isn't correct
        {
            isCorrect = false;
        }

        if (isCorrect == true)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("The expression isn't correct");
        }
    }
}
