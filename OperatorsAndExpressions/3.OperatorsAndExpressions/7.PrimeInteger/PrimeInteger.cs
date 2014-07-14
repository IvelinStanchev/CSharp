/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.*/
using System;

class PrimeInteger
{
    static void Main()
    {
        Console.Write("Enter a number in the range of 0, 100: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 100)
        {
            if ((number == 1) || (number == 2) || (number == 3)
                || (number == 5) || (number == 7))
                Console.WriteLine("The number is prime");
            else if ((number % 2 == 0) || (number % 3 == 0) || (number % 4 == 0)
                || (number % 5 == 0) || (number % 6 == 0) || (number % 7 == 0)
                || (number % 8 == 0) || (number % 9 == 0) || (number % 10 == 0))
                Console.WriteLine("The number is not prime");
            else
                Console.WriteLine("The number is prime");
        }
        else
            Console.WriteLine("Please re enter the number");
    }
}

