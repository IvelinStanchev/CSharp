/*Try to input the number with ',' or with '.'*/
using System;

class ComparingFloatingPoint
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        firstNumber = Math.Round(firstNumber, 5);// That rows "cut" the digits after the sixth one
        secondNumber = Math.Round(secondNumber, 5);

        bool equal = firstNumber == secondNumber;
        Console.WriteLine("The numbers are equal: {0}", equal);
    }
}
