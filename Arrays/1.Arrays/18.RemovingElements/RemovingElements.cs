/*Write a program that reads an array of integers and removes from it a minimal number of elements in such way 
 that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}*/
using System;
using System.Collections.Generic;

class RemovingElements
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        List<int> arrayFinal = new List<int>();
        int counter = -1;

        //Putting numbers in the array

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        

        for (int i = 0; i < length - 2; i++)
        {
            if ((array[i + 1] < array[i + 2]) || (array[i + 1] < array[i]))
            {
                counter++;
                arrayFinal.Add(array[i + 1]);
            }
        }

        counter = 0;

        for (int i = 0; i < arrayFinal.Count - 1; i++)
        {
            counter++;
            if (arrayFinal[counter] < arrayFinal[counter - 1])
            {
                arrayFinal.Remove(arrayFinal[counter]);
            }
        }
        Console.WriteLine();
        if (array[length - 1] > arrayFinal[arrayFinal.Count - 1])
        {
            arrayFinal.Add(array[length - 1]);
        }
        for (int i = 0; i < arrayFinal.Count; i++)
        {
            Console.WriteLine(arrayFinal[i]);
        }
    }
}
