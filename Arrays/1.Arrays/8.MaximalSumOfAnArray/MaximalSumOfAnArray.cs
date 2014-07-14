/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/
using System;

class MaximalSumOfAnArray
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrayOfNumber = new int[length];

        //Putting all numbers in the array

        for (int i = 0; i < length; i++)
        {
            arrayOfNumber[i] = int.Parse(Console.ReadLine());
        }

        int maximal = arrayOfNumber[0];
        int maximalEnd = arrayOfNumber[0];
        int finalSequence = 1;
        int currentSequence = 1;
        int start = 0;
        int startTemp = 0;

        for (int i = 1; i < length; i++)
        {
            if (arrayOfNumber[i] + maximalEnd > arrayOfNumber[i])
            {
                maximalEnd = arrayOfNumber[i] + maximalEnd;
                currentSequence++;
            }
            else
            {
                maximalEnd = arrayOfNumber[i];
                startTemp = i;
                currentSequence = 1;
            }
            if (maximalEnd > maximal)
            {
                maximal = maximalEnd;
                finalSequence = currentSequence;
                start = startTemp;
            }
        }

        //Printing the array

        for (int i = start; i < start + finalSequence; i++)
        {
            if (i == start)
            {
                Console.Write(arrayOfNumber[i]);
            }
            else
            {
                Console.Write(", " + arrayOfNumber[i]);
            }
        }
        Console.WriteLine();
    }
}
