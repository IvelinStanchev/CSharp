/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
 (find it in Wikipedia).*/
using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("What will be the searching number: ");
        int neededNumber = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int indexMin = 0;
        int indexMax = length - 1; ;
        int indexMiddle = (indexMin + indexMax) / 2;
        int indexOfNeededNumber = 0;
        bool flag = false;

        //I just apply the Binary Search algorithm (http://vlad0.net/binary-search/)

        while (true)
        {
            if (indexMiddle >= length - 1)//If the number isn't int the array I go out of the cycle
            {
                break;
            }
            if (array[indexMiddle] == neededNumber)//If the number is found I go out of the cycle
            {
                indexOfNeededNumber = indexMiddle;
                flag = true;
                break;
            }
            if (array[indexMiddle] > neededNumber)
            {
                indexMiddle--;
                indexMax = indexMiddle;
                indexMiddle = (indexMin + indexMax) / 2;
            }
            else
            {
                indexMiddle++;
                indexMin = indexMiddle;
                indexMiddle = (indexMin + indexMax) / 2;
            }
        }

        if (flag == false)
        {
            Console.WriteLine("The needed number isn's containing in the array");
        }
        else
        {
            Console.WriteLine(indexOfNeededNumber);
        }
    }
}
