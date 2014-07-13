/*Write a program to convert decimal numbers to their binary representation.*/
using System;
using System.Collections.Generic;

class DecimalToBinaryRepresentation
{
    static void Main()
    {
        Console.Write("Enter the decimal number: ");
        int number = int.Parse(Console.ReadLine());
        int flexibleNumber = number;//I will use it as dublicate of the original number and will divide it each time with 2
        List<int> reminders = new List<int>();

        while (flexibleNumber >= 1)
        {
            int currentReminder = 0;
            currentReminder = flexibleNumber % 2;//Taking the reminder
            reminders.Add(currentReminder);//Putting the reminder in list of ints
            flexibleNumber /= 2;
        }

        Console.Clear();
        Console.Write("{0} -> ", number);
        for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
        {
            Console.Write(reminders[i]);
        }
        Console.WriteLine();
    }
}
