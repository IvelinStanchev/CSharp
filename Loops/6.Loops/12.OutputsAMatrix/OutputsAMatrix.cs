/*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix */
using System;

class OutputsAMatrix
{
    static void Main()
    {
        Console.Write("Enter a number N in the range (1, 20): ");
        int numberN = int.Parse(Console.ReadLine());

        if ((numberN > 20) || (numberN < 1))
        {
            Console.WriteLine("{0} isn't in the range (1, 20)! Re enter the number", numberN);
        }
        else
        {
            for (int i = 1; i <= numberN; i++)
            {
                for (int j = i; j < numberN + i; j++)
                {
                    Console.Write(j + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}

