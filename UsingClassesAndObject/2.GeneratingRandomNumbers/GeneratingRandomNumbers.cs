/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/
using System;

class GeneratingRandomNumbers
{
    static void Main()
    {
        Random numbers = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numbers.Next(100, 201));
        }
    }
}
