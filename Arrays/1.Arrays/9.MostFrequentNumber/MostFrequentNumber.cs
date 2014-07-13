/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)*/
using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrayOfAllNumbers = new int[length];
        int[] arrayOfNumberInPosition = new int[length];
        int[] arrayOfCounter = new int[length];

        //Entering the numbers in array

        for (int i = 0; i < length; i++)
        {
            arrayOfAllNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfAllNumbers);
        int maxCounter = 1;
        int currentCounter = 1;
        int maxNumber = arrayOfAllNumbers[0];

        for (int i = 1; i < length; i++)
        {
            int currentNumber = i;
            while (arrayOfAllNumbers[currentNumber] == arrayOfAllNumbers[currentNumber - 1])//Checking the all same numbers and get the number which is repeated most times
            {
                currentNumber++;
                currentCounter++;
                if (currentCounter > maxCounter)
                {
                    maxCounter = currentCounter;
                    maxNumber = arrayOfAllNumbers[i];
                }
            }
            currentCounter = 1;
        }
        Console.WriteLine("{0} ({1} times)", maxNumber, maxCounter);
    }
}
