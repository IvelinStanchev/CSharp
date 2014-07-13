/*Write a program to calculate n! for each n in the range [1..100]. 
 Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */
using System;
using System.Numerics;

class CalculatingNFactorial
{
    static void CalculatingFactorial(int[] array)
    {
        BigInteger numberOfFactorial = 1;

        for (int i = 1; i <= array.Length; i++)
        {
            numberOfFactorial *= i;
            Console.WriteLine(i + " -> " + numberOfFactorial);
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[] array = new int[100];

        CalculatingFactorial(array);
    }
}
