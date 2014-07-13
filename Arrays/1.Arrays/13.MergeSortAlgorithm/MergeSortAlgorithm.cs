/*Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
 http://en.wikipedia.org/wiki/Merge_sort (I used the animation of that link to solve the problem)*/
using System;

class MergerSortAlgorithm
{
    static void Main()
    {
        Console.Write("Enter length for the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        //Putting the numbers into an array

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int helpVariable = 0;//Will be used for exchanging values

        for (int i = 0; i < length - 1; i += 2)//Rearanging each quarter
        {
            if (array[i] > array[i + 1])
            {
                helpVariable = array[i];
                array[i] = array[i + 1];
                array[i + 1] = helpVariable;
            }
        }
        for (int i = 0; i < length / 2; i++)//Rearranging the first half of the array
        {
            for (int j = i + 1; j < length / 2; j++)
            {
                if (array[j] < array[i])
                {
                    helpVariable = array[j];
                    array[j] = array[i];
                    array[i] = helpVariable;
                }
            }
        }

        for (int i = length / 2; i < length; i++)//Rearranging the second half of the array
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[i])
                {
                    helpVariable = array[j];
                    array[j] = array[i];
                    array[i] = helpVariable;
                }
            }
        }

        for (int i = 0; i < length; i++)//Rearranging the hole array
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[i])
                {
                    helpVariable = array[j];
                    array[j] = array[i];
                    array[i] = helpVariable;
                }
            }
        }

        Console.Write("The sorted array: ");

        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
