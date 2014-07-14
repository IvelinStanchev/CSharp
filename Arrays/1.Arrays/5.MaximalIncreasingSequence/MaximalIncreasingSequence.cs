/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.*/
using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("What will be the length of the array?: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[length];

        arrayOfNumbers[0] = int.Parse(Console.ReadLine());

        //Now I get the entered numbers and put them in array

        for (int i = 1; i < length; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            arrayOfNumbers[i] = currentNumber;
        }

        int lastNumberOfMaximalIncreasingSequence = arrayOfNumbers[0];//This will be the maximal number if there are no other numbers
        int currentLengthOfTheIncreasingSequence = 1;//This will be my dynamic variable which I will use to perambulate the array
        int maxLengthOfTheIncreasingSequence = 1;//Here I will keep the maximal sequence of equal numbers

        //Now I will check if there are any increasing sequences

        for (int i = 1; i < length; i++)
        {
            if (arrayOfNumbers[i - 1] == (arrayOfNumbers[i] - 1))
            {
                currentLengthOfTheIncreasingSequence++;//If the next number is bigger with 1 I increase the length with 1
                if (currentLengthOfTheIncreasingSequence > maxLengthOfTheIncreasingSequence)//With this row I check if current sequence is the biggest
                {
                    lastNumberOfMaximalIncreasingSequence = arrayOfNumbers[i];
                    maxLengthOfTheIncreasingSequence = currentLengthOfTheIncreasingSequence;
                }
            }
            else
            {
                currentLengthOfTheIncreasingSequence = 1;
            }
        }

        int firstNumberOfTheMaximalSequence = lastNumberOfMaximalIncreasingSequence - maxLengthOfTheIncreasingSequence + 1;//From this number I will start printing the sequence on the console

        //Now I will print the numbers in the maximal increasing sequence

        Console.Write("The maximal increasing sequence is: ");
        for (int i = 0; i < maxLengthOfTheIncreasingSequence; i++)
        {
            if (i == 0)
            {
                Console.Write(firstNumberOfTheMaximalSequence);
            }
            else
            {
                Console.Write(", " + firstNumberOfTheMaximalSequence);
            }
            firstNumberOfTheMaximalSequence++;
        }
        Console.WriteLine();
    }
}
