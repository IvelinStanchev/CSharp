/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
 if there’s no such element.
Use the method from the previous exercise.*/
using System;

class BiggerThanIts2Neighbors
{
    static int IsBiggerThanTheTwoNeighbors(int[] array)
    {
        int index = 0;
        for (int i = 1; i < array.Length - 1; i++)
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
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("array[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        if (IsBiggerThanTheTwoNeighbors(array) == 0)
        {
            Console.Write("There is no such element: ");
            Console.WriteLine("-1");
        }
        else
        {
            Console.Write("The index is: ");
            Console.WriteLine(IsBiggerThanTheTwoNeighbors(array));
        }
    }
}
