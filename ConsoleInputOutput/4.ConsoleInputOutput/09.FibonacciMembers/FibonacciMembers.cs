/*Write a program to print the first 100 members of the sequence of Fibonacci: 
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/
using System;
using System.Numerics;

class FibonacciMembers
{
    static void Main()
    {
        BigInteger[] fibonacciMembers = new BigInteger[100];//I use the type BigInteger because its bigger than ulong
        fibonacciMembers[0] = 0;
        fibonacciMembers[1] = 1;
        fibonacciMembers[2] = 1;

        for (int i = 3; i < 100; i++)//Calculating the members in the sequence of Fibonacci 
        {
            fibonacciMembers[i] = fibonacciMembers[i - 1] + fibonacciMembers[i - 2];
        }

        for (int i = 0; i < 100; i++)//Printing the first 100 members of the sequence of Fibonacci
        {
            Console.WriteLine(i + 1 + " - > " + fibonacciMembers[i]);
        }
    }
}

