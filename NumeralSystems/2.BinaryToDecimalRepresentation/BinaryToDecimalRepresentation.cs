/*Write a program to convert binary numbers to their decimal representation.*/
using System;
using System.Collections.Generic;

class BinaryToDecimalRepresentation
{
    static void Main()
    {
        Console.Write("What is the number in binary representation?: ");
        string flexibleBinaryNumber = Console.ReadLine();
        string binaryNumber = flexibleBinaryNumber;
        List<int> digitsOfTheNumber = new List<int>();
        int decimalNumber = 0;
        //Getting each digit of the entered number to an array
        for (int i = 0; i < flexibleBinaryNumber.Length; i++)
        {
            digitsOfTheNumber.Add(flexibleBinaryNumber[i] - '0');
        }

        //Taking each digit and multiply it by power of 2
        int currentPosition = 0;//This will save the current position
        for (int i = digitsOfTheNumber.Count - 1; i >= 0; i--)//I want to start from the last right number which is the digitsOfTheNumber[digitsOfTheNumber.Count - 1]
        {
            double currentDigit = 0.0;
            currentDigit = digitsOfTheNumber[i] * (Math.Pow(2, currentPosition));
            decimalNumber = decimalNumber + (int)currentDigit;
            currentPosition++;
        }
        Console.Clear();
        Console.WriteLine("{0} -> {1}", binaryNumber, decimalNumber);
    }
}
