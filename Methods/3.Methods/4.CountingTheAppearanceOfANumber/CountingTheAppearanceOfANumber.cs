/*Write a method that counts how many times given number appears in given array. 
 Write a test program to check if the method is working correctly.*/
using System;

class CountingTheAppearanceOfANumber
{
    static int CountingAppearanceTimes(int[] array, int number)
    {
        int counter = 0;//This variable will contain the times given number appears in array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        Console.Write("What is the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter the number: ");
        int sayNumber = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("array[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("The number {0} appears {1} times", sayNumber, CountingAppearanceTimes(array, sayNumber));
    }
}
