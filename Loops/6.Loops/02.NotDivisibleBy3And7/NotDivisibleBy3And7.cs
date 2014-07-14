/*Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/
using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers in the range (1, {0})\nthat are not divisible by 3 and 7 at the same time are:", number);
        for (int i = 1; i <= number; i++)
        {
            if (i % 21 == 0)//One number can be divided by 3 and 7 at the same time when it can be divided by 21
            {
                Console.WriteLine();//If the number can be divided we print new row
            }
            else
            {
                Console.WriteLine(i);//If the number can't be divided we print the next number
            }
        }
    }
}
