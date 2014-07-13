/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.*/
using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[length];

        int counter = 1;//This will be my dynamic variable which I will use to perambulate the array
        int maxCounter = 1;//Here I will keep the maximal sequence of equal numbers
        int greatestNumber = 0;//This will be the maximal's length number

        arrayOfNumbers[0] = int.Parse(Console.ReadLine());
        greatestNumber = arrayOfNumbers[0];//We get the first value for greatest in case there are no other numbers

        //Now I get the entered numbers and put them in array

        for (int i = 1; i < length; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            arrayOfNumbers[i] = currentNumber;
        }

        //Checking if there is any maximal sequence of maximal elements

        for (int i = 1; i < length; i++)
        {
            if (arrayOfNumbers[i - 1] == arrayOfNumbers[i])
            {
                counter++;//If the next number is equal to the last one counter is incremented by 1
                if (counter > maxCounter)
                {
                    maxCounter = counter;//This will make the length of the maximal sequence
                    greatestNumber = arrayOfNumbers[i];//The greatest number will be the number that is same to the last one
                }
            }
            else
            {
                counter = 1;
            }
        }

        Console.WriteLine(new string('-', 50));

        //Now I print the sequence of the same numbers

        Console.Write("The maximal sequence of equal elements is: ");
        for (int i = 0; i < maxCounter; i++)
        {
            if (i == 0)
            {
                Console.Write(greatestNumber);
            }
            else
            {
                Console.Write(", " + greatestNumber);
            }
        }
        Console.WriteLine();
    }
}
