using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Recursion
{
    static void PrintingEachPermutation(int[] eachCombination)
    {
        foreach (var number in eachCombination)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }

    static void GeneratingNumbers(int inputLength, int[] eachCombination, int start)
    {
        inputLength = inputLength - 1;
        if (inputLength == -1)
        {
            PrintingEachPermutation(eachCombination);
        }
        else
        {
            for (int i = start; i <= inputLength + 2; i++)
            {
                eachCombination[inputLength] = i;
                GeneratingNumbers(inputLength - 1, eachCombination, i + 1);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int length = int.Parse(Console.ReadLine());
        int[] currentPermutation = new int[length];
        Console.WriteLine("All permutations in the range (1, {0}) are: ", length);
        GeneratingNumbers(length - 2, currentPermutation, 1);
    }
}
