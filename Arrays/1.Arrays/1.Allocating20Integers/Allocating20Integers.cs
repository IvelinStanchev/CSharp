/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
  Print the obtained array on the console.*/
using System;

class Allocating20Integers
{
    static void Main()
    {
        int[] arrayOfNumbers = new int[20];

        Console.WriteLine("Enter 20 integer numbers: ");

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        Console.WriteLine("The index multiplied by 5: ");
        Console.WriteLine();

        for (int j = 0; j < arrayOfNumbers.Length; j++)
        {
            Console.WriteLine("numbers[{0}] -> {1} * 5 -> {2}", j, arrayOfNumbers[j], arrayOfNumbers[j] * 5);
        }
    }
}
