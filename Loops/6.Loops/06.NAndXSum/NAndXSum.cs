/*Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN*/
using System;

class NAndXSum
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for X: ");
        int numberX = int.Parse(Console.ReadLine());

        double sum = 1;
        int nFactorial = 1;

        for (int i = 1; i <= numberN; i++)
        {
            nFactorial *= i;
            sum += nFactorial / Math.Pow(numberX, i);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}