/*Write a program to convert hexadecimal numbers to their decimal representation.*/
using System;
using System.Collections.Generic;

class HexadecimalToDecimalRepresentation
{
    static void Main()
    {
        Console.Write("What is the number in hexadecimal representation?: ");
        string flexibleHexadecimalNumber = Console.ReadLine().ToUpper();//To.Upper makes all entered letters big even if they are not
        string hexadecimalNumber = flexibleHexadecimalNumber;
        List<int> digitsOfTheNumber = new List<int>();
        int decimalNumber = 0;

        //Getting each digit of the entered number to an array
        for (int i = 0; i < flexibleHexadecimalNumber.Length; i++)
        {
            if (flexibleHexadecimalNumber[i] > 57)
            {
                digitsOfTheNumber.Add(flexibleHexadecimalNumber[i] - '7');//If its letter I get '7' or 55 of it to make it number
            }
            else
            {
                digitsOfTheNumber.Add(flexibleHexadecimalNumber[i] - '0');//I just add the current char as a number
            }
        }

        //Taking each digit and multiply it by power of 16
        int currentPosition = 0;//This will save the current position
        for (int i = digitsOfTheNumber.Count - 1; i >= 0; i--)//I want to start from the last right number which is the digitsOfTheNumber[digitsOfTheNumber.Count - 1]
        {
            if (digitsOfTheNumber[i] > 57)//I check if the current string is number or letter
            {
                digitsOfTheNumber[i] -= '7';//If its letter I get '7' or 55 of it to make it letter
            }
            double currentDigit = 0.0;
            currentDigit = digitsOfTheNumber[i] * (Math.Pow(16, currentPosition));
            decimalNumber = decimalNumber + (int)currentDigit;
            currentPosition++;
        }
        Console.Clear();
        Console.WriteLine("{0} -> {1}", hexadecimalNumber, decimalNumber);       
    }
}
