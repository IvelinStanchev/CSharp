/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/
using System;
using System.Collections.Generic;

class BinaryRepresentationOfTypeShort
{
    static void Main()
    {
        Console.Write("Enter a number (short type number): ");
        short number = short.Parse(Console.ReadLine());

        if (number >= 0)
        {
            int flexibleNumber = number;
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
            for (int i = reminders.Count; i < 16; i++)//I want to add zeros in the start of the number because it is 16 bits
            {
                reminders.Add(0);
            }

            for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
            {
                Console.Write(reminders[i]);
            }
            Console.WriteLine();
        }
        else
        {
            int flexibleNumber = ~number;
            //~number because the negative numbers have the same bits like the ~number but reversed
            //Here is what I mean:
            //if we have -5. Its binary representation is 1111111111111011
            //~(-5) is 4.    Its binary representation is 0000000000000100
            //So I will reverse each bit - 0 will go to 1 and 1 to 0
            List<int> reminders = new List<int>();
            List<int> finalBits = new List<int>();

            while (flexibleNumber >= 1)
            {
                int currentReminder = 0;
                currentReminder = flexibleNumber % 2;//Taking the reminder
                reminders.Add(currentReminder);//Putting the reminder in list of ints
                flexibleNumber /= 2;
            }

            Console.Clear();
            Console.Write("{0} -> ", number);
            for (int i = reminders.Count; i < 16; i++)//I want to add zeros in the start of the number because it is 16 bits
            {
                reminders.Add(0);
            }

            for (int i = 0; i < reminders.Count; i++)
            {
                int addingBit;
                addingBit = reminders[i] ^ 1;
                finalBits.Add(addingBit);
            }

            for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
            {
                Console.Write(finalBits[i]);
            }
            Console.WriteLine();
        }
    }
}
