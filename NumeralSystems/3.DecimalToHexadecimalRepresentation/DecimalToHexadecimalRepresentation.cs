/*Write a program to convert decimal numbers to their hexadecimal representation.*/
using System;
using System.Collections.Generic;

class DecimalToHexadecimalRepresentation
{
    static void Main()
    {
        string[] containingAllHexs = new string[16]{ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        int flexibleNumber = number;//I will change the flexibleNumber many times
        List<string> hexadecimalNumber = new List<string>();

        while (flexibleNumber > 0)
        {
            int currentReminder;
            currentReminder = flexibleNumber % 16;
            hexadecimalNumber.Add(containingAllHexs[currentReminder]);
            flexibleNumber /= 16;
        }

        //Printing the number
        Console.Clear();
        Console.Write("{0} -> ", number);
        for (int i = hexadecimalNumber.Count - 1; i >= 0; i--)
        {
            Console.Write(hexadecimalNumber[i]);
        }
        Console.WriteLine();
    }
}
