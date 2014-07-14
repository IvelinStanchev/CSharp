/*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/
using System;

class PermutationsOfANumber
{
    static void PermutingTheArray(int[] array, int currentPosition)
    {
        if (currentPosition == array.Length)
        {
            PrintingTheArray(array);
        }
        else
        {
            for (int i = currentPosition; i < array.Length; i++)
            {
                ExchangingValues(ref array[i], ref array[currentPosition]);
                PermutingTheArray(array, currentPosition + 1);
                ExchangingValues(ref array[i], ref array[currentPosition]);
            }
        }
    }

    static void ExchangingValues(ref int firstNumber, ref int secondNumber)//This method will help me to exchange the values
    {
        int helpForExchanging = firstNumber;
        firstNumber = secondNumber;
        secondNumber = helpForExchanging;
    }

    static int counter = 0;//How many permutation exist

    static void PrintingTheArray(int[] array)
    {
        counter++;
        Console.Write(counter + " -   ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("What will be the number: ");
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];

        for (int i = 1; i <= N; i++)//Getting the numbers from 1 to N into an array
        {
            arrayOfNumbers[i - 1] = i;
        }

        PermutingTheArray(arrayOfNumbers, 0);
    }
}
