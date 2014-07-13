/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/
using System;

class VariationsOfANumber
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());

    static void EachVariation(int[] eachVariation, int currentIndex)
    {
        if (currentIndex == eachVariation.Length)
        {
            PrintingEachVariation(eachVariation);//If the current index is equal to the K we print the array
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                eachVariation[currentIndex] = i;
                EachVariation(eachVariation, currentIndex + 1);
            }
        }
    }

    static void PrintingEachVariation(int[] eachVariation)
    {
        for (int i = 0; i < eachVariation.Length; i++)
        {
            Console.Write(eachVariation[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main()
    {
        int[] eachVariation = new int[K];
        EachVariation(eachVariation, 0);//The starting index will be 0 because the array's indexes start from 0
    }
}
