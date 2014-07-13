/*Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 
 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length for the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter S(sum): ");
        int sum = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        //Getting the numbers in array

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = i, currentSum = 0; j < length; j++)
            {
                if ((currentSum += array[j]) == sum)
                {
                    for (int k = 0; k < (j - i + 1); k++)
                    {
                        if (k == 0)
                        {
                            Console.Write(array[i + k]);
                        }
                        else
                        {
                            Console.Write(", " + array[i + k]);
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
