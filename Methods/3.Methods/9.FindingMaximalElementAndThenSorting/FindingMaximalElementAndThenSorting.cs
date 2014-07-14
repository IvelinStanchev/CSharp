/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
 Using it write another method that sorts an array in ascending / descending order.*/
using System;

class FindingMaximalElementAndThenSorting
{

    static void EnteringTheArray(int[] array)//Entering the array's numbers
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void SortArrayDescending(int[] array)//I sort the array in descending order
    {
        int maxElementIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            maxElementIndex = FindingMaximalElement(i, array);//I get the maximal element and swap it with the current one

            int helpToSwap = array[i];
            array[i] = array[maxElementIndex];
            array[maxElementIndex] = helpToSwap;
        }
    }

    static void SortArrayAscending(int[] array)//I reverse the array that is in descending order to make it in ascending one
    {
        Array.Reverse(array);    
    }

    static int FindingMaximalElement(int startingIndex, int[] array)//I find the maximal element of the array starting from the entered index
    {
        int indexOfMaximalElement = startingIndex;

        for (int i = startingIndex; i < array.Length; i++)
        {
            if (array[i] > array[indexOfMaximalElement])//If the element at current index is bigger than the index of the maximal element I get the current index
            {
                indexOfMaximalElement = i;
            }
        }
        return indexOfMaximalElement;
    }

    static void PrintingTheArray(int[] array)//I print the array
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void Main()
    {
        Console.Write("What will be the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("What will be the starting index: ");
        int startingIndex = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        EnteringTheArray(array);
        FindingMaximalElement(startingIndex, array);

        int maximalElementWithIndex = FindingMaximalElement(startingIndex, array);//This variable will contain the index of the maximal element of the array
        Console.WriteLine("The maximal element in the range ({0}, {1}) is: {2}", startingIndex, length - 1, array[maximalElementWithIndex]);
        Console.WriteLine();

        Console.Write("The array in descending order is: ");
        SortArrayDescending(array);
        PrintingTheArray(array);

        Console.WriteLine();

        Console.Write("The array in ascending order is: ");
        SortArrayAscending(array);
        PrintingTheArray(array);
        Console.WriteLine();
    }
}
