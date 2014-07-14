/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 Find in the array those K elements that have maximal sum.*/
using System;

class MaximalSum
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("N must be bigger than K!\nThe numbers must be positive!");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
        int P = 0;
        int Q = 0;

        do
        {
            Console.Write("Enter a number for N: ");
            P = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for K: ");
            Q = int.Parse(Console.ReadLine());
            Console.WriteLine();
        } while (P < Q);

        int N = P;
        int K = Q;

        int[] arrayN = new int[N];
        for (int i = 0; i < N; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Array.Sort(arrayN);//I sort the array

        Console.Write("With maximal sum are the elements: ");
        for (int i = N - K; i < N; i++)//I get the last K element which are the biggest after the sorting
        {
            if (i == (N - K))
            {
                Console.Write(arrayN[i]);
            }
            else
            {
                Console.Write(", " + arrayN[i]);
            } 
        }
        Console.WriteLine();
    }
}
