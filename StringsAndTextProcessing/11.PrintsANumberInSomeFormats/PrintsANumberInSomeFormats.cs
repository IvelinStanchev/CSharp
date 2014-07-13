/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
 Format the output aligned right in 15 symbols.*/
using System;

class PrintsANumberInSomeFormats
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        PrintingTheEnteredNumberInVariousFormats(number);
    }

    private static void PrintingTheEnteredNumberInVariousFormats(int number)
    {
        Console.WriteLine("Decimal number: {0,15}", number);
        Console.WriteLine("Hexadecimal number: {0,15:X4}", number);
        Console.WriteLine("Percentage: {0,15:P}", number);
        Console.WriteLine("Scientific: {0,15:E}", number);
    }
}
