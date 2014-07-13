/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors 
 (when such exist).*/
using System;

class BiggerThanIts2Neighbors//The position must be LOWER than the length of the array (In case its equal we won't have two neighbors)
{//                          //The position must be also bigger than 1 (In case its equal to 1 we won't have two neighbors)
    static int IsBiggerThanTheTwoNeighbors(int[] array, int position)
    {
        int index = 0;
        for (int i = position - 1; i < array.Length; i++)
        {
            if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
            {
                index = i;
                break;
            }
        }
        return index;
    }

    static void Main()
    {
        Console.Write("What is the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter the position: ");
        int sayPosition = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("array[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        if (sayPosition == (IsBiggerThanTheTwoNeighbors(array, sayPosition) + 1))
        {
            Console.WriteLine("The element at positon {0} is bigger than its two neighbors", sayPosition);
        }
        else
        {
            Console.WriteLine("The element at positon {0} is not bigger than its two neighbors", sayPosition);
        }
    }
}
