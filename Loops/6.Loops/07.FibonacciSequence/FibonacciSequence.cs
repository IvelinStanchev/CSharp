/*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/
using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Enter a number N for the members of the sequence of Fibonacci: ");
        int numberN = int.Parse(Console.ReadLine());

        BigInteger sum = 0;
        BigInteger[] fibonacci = new BigInteger[numberN];

        if (numberN > 3)
        {
            fibonacci[0] = 0;//First element of the sequence of Fibonacci
            fibonacci[1] = 1;//Second element of the sequence of Fibonacci
            fibonacci[2] = 1;//Third element of the sequence of Fibonacci

            Console.WriteLine("The Fibonacci sequence with {0} elements is: ", numberN);
            Console.WriteLine();

            Console.WriteLine("1 -> {0}", fibonacci[0]);
            Console.WriteLine("2 -> {0}", fibonacci[1]);
            Console.WriteLine("3 -> {0}", fibonacci[2]);
            for (int i = 3; i < numberN; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                Console.WriteLine("{0} -> {1}", i + 1, fibonacci[i]);
                sum += fibonacci[i];
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1}", numberN, sum + 2 );
        }
        else if (numberN == 0)//If the inputted number is lower than 3
        {
            sum = 0;
            Console.WriteLine();
            Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1}", numberN, sum);
        }
        else if (numberN == 1)
        {
            sum = 0;
            Console.WriteLine("The Fibonacci sequence with {0} element is: ", numberN);
            Console.WriteLine();
            Console.WriteLine("1 -> 0");
            Console.WriteLine();
            Console.WriteLine("The sum of the first member of the Fibonacci sequence is: {0}", sum);
        }
        else if (numberN == 2)
        {
            sum = 0;
            Console.WriteLine("The Fibonacci sequence with {0} elements is: ", numberN);
            Console.WriteLine();
            Console.WriteLine("1 -> 0");
            Console.WriteLine("2 -> 0");
            Console.WriteLine();
            Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1}", numberN, sum);
        }
        else if (numberN == 3)
        {
            sum = 1;
            Console.WriteLine("The Fibonacci sequence with {0} elements is: ", numberN);
            Console.WriteLine();
            Console.WriteLine("1 -> 0");
            Console.WriteLine("2 -> 0");
            Console.WriteLine("3 -> 1");
            Console.WriteLine();
            Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1}", numberN, sum);
        }
    }
}

