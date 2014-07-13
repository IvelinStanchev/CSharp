/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm */
using System;
using System.Collections.Generic;

class PrimeNumbersEratosthenesAlgorithm
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int length = 10000000;

        for (int i = 8; i <= length; i++)
        {
            if (((i % 2) != 0) && ((i % 3) != 0) && ((i % 5) != 0) && ((i % 7) != 0))//It's the same if I remove the elements at 2nd, 3rd, 5th and 7th positions
            {
                numbers.Add(i);//Simply adding these elements which are not at 2nd, 3rd, 5th and 7th positions
            }
        }

        //Printing all of the numbers

        Console.Write("2 " + "3 " + "5 " + "7 ");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}