/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/
using System;

class ExchangingBits
{
    static void Main()
    {
        Console.Write("Enter your integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);
        Console.Write("The number in binary type is: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int firstPosition = 3;
        int secondPosition = 24;

        int firstMask = 7 << firstPosition;
        int secondMask = 7 << secondPosition;

        int firstChecking = number & firstMask;
        int secondChecking = number & secondMask;
        int changingBits = (number & ~firstMask) & ~secondMask;

        int mask3 = (firstChecking >> firstPosition) << secondPosition;
        int mask4 = (secondChecking >> secondPosition) << firstPosition;
        int result = (changingBits | mask3) | mask4;

        Console.Write("The result after changing is: ");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

