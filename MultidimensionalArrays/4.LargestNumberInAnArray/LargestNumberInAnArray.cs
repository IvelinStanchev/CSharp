/*Write a program, that reads from the console an array of N integers and an integer K, 
 sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/
using System;

class LargestNumberInAnArray
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        Console.WriteLine();
        Console.WriteLine("Enter {0} numbers: ", N);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] - > ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
 
        int searchedNumber = Array.BinarySearch(array, K);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
 
        if (searchedNumber < (-1))
        {
            Console.WriteLine("The largest number that is lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
        }
    }
}
