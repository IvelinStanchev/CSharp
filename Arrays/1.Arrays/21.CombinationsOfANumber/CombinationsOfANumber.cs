/*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/
using System;

class CombinationsOfANumber
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());

    static void EachVariation(int[] eachVariation, int currentIndex, int startingIndex)
    {
        if (currentIndex == eachVariation.Length)
        {
            PrintingEachVariation(eachVariation);//If the current index is equal to the K we print the array
        }
        else
        {
            for (int i = startingIndex; i <= N; i++)
            {
                eachVariation[currentIndex] = i;
                EachVariation(eachVariation, currentIndex + 1, startingIndex + 1);
                startingIndex++;//Everytime the neighbour number will be with 1 bigger
            }
        }
    }

    static void PrintingEachVariation(int[] eachVariation)
    {
        Console.WriteLine();
        for (int i = 0; i < eachVariation.Length; i++)
        {
            Console.Write(eachVariation[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] eachVariation = new int[K];
        int startingIndex = 1;
        EachVariation(eachVariation, 0, startingIndex);//The starting index will be 0 because the array's indexes start from 0
    }
}
