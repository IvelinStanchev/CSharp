/*Write a program that calculates N!/K! for given N and K (1<K<N).*/
using System;
using System.Numerics;

class NAndKFactorial
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger divide = 1;

        if ((n < 2) || (k < 1))
        {
            Console.WriteLine("Error! Please re enter the number");
        }
        else if (k >= n)
        {
            Console.WriteLine("K must be lower than N");
        }
        else
        {
            for (int i = (k + 1); i <= n; i++)//When n! / k! the numbers which are didvided from 1 to k make 1 and we print the number after k+1 to n
            {
                divide *= i;
            }
            Console.WriteLine("The final number is: {0}", divide);
        }
    }
}

