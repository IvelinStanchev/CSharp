/*Write a method that reverses the digits of given decimal number. Example: 256 -> 652*/
using System;

class ReversingTheDigitsOfANumber
{
    static int ReverseInt(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return reversed;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The reversed number is: ");
        Console.WriteLine(ReverseInt(number));
    }
}
