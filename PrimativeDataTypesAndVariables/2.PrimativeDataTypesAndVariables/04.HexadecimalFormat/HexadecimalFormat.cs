using System;

class HexadecimalFormat
{
    static void Main()
    {
        Console.Write("Enter the integer type value: ");
        int decValue = int.Parse(Console.ReadLine());
        string hexValue = decValue.ToString("X");
        Console.Write("The value in hexadecimal type is: ");
        Console.WriteLine(hexValue);
    }
}

