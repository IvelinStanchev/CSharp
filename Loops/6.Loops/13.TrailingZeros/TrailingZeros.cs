/*Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10 -> N! = 3628800 -> 2
	N = 20 -> N! = 2432902008176640000 -> 4*/
using System;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int numberN = int.Parse(Console.ReadLine());

        int trailingZerosNumber = 0;

        for (int i = 1; i < numberN; i++)
        {
            trailingZerosNumber += (numberN / (int)Math.Pow(5, i));

            if (trailingZerosNumber > numberN)
            {
                break;
            }
        }
        Console.WriteLine("The trailing zeros of {0}! are: {1}", numberN, trailingZerosNumber);
    }
}
