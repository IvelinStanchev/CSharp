/*Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format 
 (the C# type float). Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
 I used that article to help me solving the task 
 http://www.telerik-vats.cloudvps.bg/9-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-%D0%BE%D1%82-%D0%B1%D1%80%D0%BE%D0%B9%D0%BD%D0%B8-%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B8/ */
using System;
using System.Collections.Generic;

class FloatingpointNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        string number = Console.ReadLine();
        int sign = 0;
        List<char> finalMantissa = new List<char>();
        string exponent = "";
        int positionOfTheComma = 0;
        string numberInLeftOfTheComma = "";
        string numberInRightOfTheComma = "";
        string rightSide = "";
        int flexingLeftSide = 0;
        double flexindRightSide = 0.0;

        if (number.Substring(0, 1) == "-")//Substring - If we have -27.25, then we check the string between the first index (0)
        {//                                 and the second index (1) if its "-". If so then the number is negative
            sign = 1;
        }

        for (int i = 0; i < number.Length; i++)//I find the index of the comma
        {
            if ((number[i] == '.') || (number[i] == ','))
            {
                positionOfTheComma = i;
            }
        }

        for (int i = positionOfTheComma + 1; i < number.Length; i++)//I add the numbers in right of the comma in numberInRightOfTheComma
        {
            numberInRightOfTheComma += number[i];
        }

        for (int i = 0; i < positionOfTheComma; i++)//I add the numbers in left of the comma in numberInLeftOfTheComma
        {
            if (number[i] != '-')
            {
                numberInLeftOfTheComma += number[i];
            }
        }

        flexindRightSide = double.Parse(numberInRightOfTheComma);
        numberInRightOfTheComma = "";
        flexingLeftSide = Convert.ToInt32(numberInLeftOfTheComma);
        numberInLeftOfTheComma = Convert.ToString(flexingLeftSide, 2);//Get the binary representation

        int counter = 0;
        while ((flexindRightSide != 1) && (counter < 23))
        {
            flexindRightSide = flexindRightSide * 2;

            if (flexindRightSide < 100f)
            {
                rightSide += "0";
            }
            else
            {
                flexindRightSide -= 100;
                rightSide += "1";
            }
            counter++;
        }

        //Calculating the exponent
        exponent = Convert.ToString((127 + (numberInLeftOfTheComma.Length - 1)), 2);

        //Calculating the mantissa
        for (int i = 1; i < numberInLeftOfTheComma.Length; i++)
        {
            finalMantissa.Add(numberInLeftOfTheComma[i]);
        }

        for (int i = 0; i < rightSide.Length; i++)
        {
            finalMantissa.Add(rightSide[i]);      
        }

        Console.WriteLine("Sign -> {0}", sign);
        Console.WriteLine("Exponent -> {0}", exponent);
        Console.Write("Mantissa -> ");
        for (int i = 0; i < finalMantissa.Count - 4; i++)//Printing the mantissa
        {
            Console.Write(finalMantissa[i]);
        }
        Console.WriteLine();
    }
}
