/*Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/
using System;

class DivideBy5and7
{
    static void Main()
    {
        bool firstCheck;
        Console.Write("Enter a number to see if it could be divided by 5 and 7 in the same time: ");
        int numberInt = int.Parse(Console.ReadLine());
        if ((numberInt % 5 == 0) && (numberInt % 7 == 0))
            firstCheck = true;
        else
            firstCheck = false;
        Console.WriteLine("The number can be divided by 5 and 7 in the same time: {0}", firstCheck);
    }
}

