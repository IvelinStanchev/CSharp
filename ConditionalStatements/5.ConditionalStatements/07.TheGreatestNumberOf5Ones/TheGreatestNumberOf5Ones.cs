/*Write a program that finds the greatest of given 5 variables.*/
using System;

class TheGreatestNumberOf5Ones
{
    static void Main()
    {
        Console.Write("Enter a first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        int[] massiveOf5Numbers = new int[5];
        massiveOf5Numbers[0] = firstNumber;
        massiveOf5Numbers[1] = secondNumber;
        massiveOf5Numbers[2] = thirdNumber;
        massiveOf5Numbers[3] = fourthNumber;
        massiveOf5Numbers[4] = fifthNumber;

        int bigNumber = massiveOf5Numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (massiveOf5Numbers[i] > bigNumber)
            {
                bigNumber = massiveOf5Numbers[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine("The greatest numbers of 5 ones is: {0}", bigNumber);
    }
}
