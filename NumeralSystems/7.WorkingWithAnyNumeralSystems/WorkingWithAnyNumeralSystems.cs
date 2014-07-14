/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/
using System;
using System.Collections.Generic;

class WorkingWithAnyNumeralSystems
{
    static void Main(string[] args)
    {
        //I am just getting the solution of the previous problems
        Console.Write("From what numeral system you want to convert?: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("To what numeral system you want to convert?: ");
        int d = int.Parse(Console.ReadLine());

        if ((s >= d) && (s != 16) && (d != 16))
        {
            Console.Write("Enter the number: ");
            string flexibleNumber = Console.ReadLine();
            List<int> digitsOfTheNumber = new List<int>();
            int decimalNumber = 0;

            //Getting each digit of the entered number to an array
            for (int i = 0; i < flexibleNumber.Length; i++)
            {
                digitsOfTheNumber.Add(flexibleNumber[i] - '0');
            }

            //Taking each digit and multiply it by power of s
            int currentPosition = 0;//This will save the current position
            for (int i = digitsOfTheNumber.Count - 1; i >= 0; i--)//I want to start from the last right number which is the digitsOfTheNumber[digitsOfTheNumber.Count - 1]
            {
                double currentDigit = 0.0;
                currentDigit = digitsOfTheNumber[i] * (Math.Pow(s, currentPosition));
                decimalNumber = decimalNumber + (int)currentDigit;
                currentPosition++;
            }

            int flexingNumber = decimalNumber;//I will use it as a dublicate of the original number and will divide it each time by s
            List<int> reminders = new List<int>();

            while (flexingNumber >= 1)
            {
                int currentReminder = 0;
                currentReminder = flexingNumber % d;//Taking the reminder
                reminders.Add(currentReminder);//Putting the reminder in list of ints
                flexingNumber /= d;
            }

            Console.Clear();
            Console.Write("{0} -> ", flexibleNumber);
            for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
            {
                Console.Write(reminders[i]);
            }
            Console.WriteLine();
        }
        else if ((s < d) && (s != 16) && (d != 16))
        {
            Console.Write("Enter the number: ");
            string flexibleNumber = Console.ReadLine();
            List<int> digitsOfTheNumber = new List<int>();
            int decimalNumber = 0;

            //Getting each digit of the entered number to an array
            for (int i = 0; i < flexibleNumber.Length; i++)
            {
                digitsOfTheNumber.Add(flexibleNumber[i] - '0');
            }

            //Taking each digit and multiply it by power of s
            int currentPosition = 0;//This will save the current position
            for (int i = digitsOfTheNumber.Count - 1; i >= 0; i--)//I want to start from the last right number which is the digitsOfTheNumber[digitsOfTheNumber.Count - 1]
            {
                double currentDigit = 0.0;
                currentDigit = digitsOfTheNumber[i] * (Math.Pow(s, currentPosition));
                decimalNumber = decimalNumber + (int)currentDigit;
                currentPosition++;
            }
            
            int flexingNumber = decimalNumber;//I will use it as dublicate of the original number and will divide it each time by d
            List<int> reminders = new List<int>();

            while (flexingNumber >= 1)
            {
                int currentReminder = 0;
                currentReminder = flexingNumber % d;//Taking the reminder
                reminders.Add(currentReminder);//Putting the reminder in list of ints
                flexingNumber /= d;
            }

            Console.Clear();
            Console.Write("{0} -> ", flexibleNumber);
            for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
            {
                Console.Write(reminders[i]);
            }
            Console.WriteLine();

        }
        else if ((s >= d) && (s == 16))
        {
            Console.Write("Enter the number: ");
            string flexibleNumber = Console.ReadLine().ToUpper();//To.Upper makes all entered letters big even if they are not;
            List<int> digitsOfTheNumber = new List<int>();
            List<int> reminders = new List<int>();
            int decimalNumber = 0;

            //Getting each digit of the entered number to an array
            for (int i = 0; i < flexibleNumber.Length; i++)
            {
                if (flexibleNumber[i] > 57)
                {
                    digitsOfTheNumber.Add(flexibleNumber[i] - '7');//If its letter I get '7' or 55 of it to make it number
                }
                else
                {
                    digitsOfTheNumber.Add(flexibleNumber[i] - '0');//I just add the current char as a number
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
                currentDigit = digitsOfTheNumber[i] * (Math.Pow(s, currentPosition));
                decimalNumber = decimalNumber + (int)currentDigit;
                currentPosition++;
            }

            while (decimalNumber >= 1)
            {
                int currentReminder = 0;
                currentReminder = decimalNumber % d;//Taking the reminder
                reminders.Add(currentReminder);//Putting the reminder in list of ints
                decimalNumber /= d;
            }

            Console.Clear();
            Console.Write("{0} -> ", flexibleNumber);
            for (int i = reminders.Count - 1; i >= 0; i--)//Printing each number from the list from the last number to the first
            {
                Console.Write(reminders[i]);
            }
            Console.WriteLine(); 
        }
        else if ((s < d) && (d == 16))
        {
            Console.Write("Enter the number: ");
            string flexibleNumber = Console.ReadLine();
            List<int> digitsOfTheNumber = new List<int>();
            int decimalNumber = 0;

            //Getting each digit of the entered number to an array
            for (int i = 0; i < flexibleNumber.Length; i++)
            {
                digitsOfTheNumber.Add(flexibleNumber[i] - '0');
            }

            //Taking each digit and multiply it by power of s
            int currentPosition = 0;//This will save the current position
            for (int i = digitsOfTheNumber.Count - 1; i >= 0; i--)//I want to start from the last right number which is the digitsOfTheNumber[digitsOfTheNumber.Count - 1]
            {
                double currentDigit = 0.0;
                currentDigit = digitsOfTheNumber[i] * (Math.Pow(s, currentPosition));
                decimalNumber = decimalNumber + (int)currentDigit;
                currentPosition++;
            }

            string[] containingAllHexs = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            List<string> hexadecimalNumber = new List<string>();

            while (decimalNumber > 0)
            {
                int currentReminder;
                currentReminder = decimalNumber % d;
                hexadecimalNumber.Add(containingAllHexs[currentReminder]);
                decimalNumber /= d;
            }

            //Printing the number
            Console.Clear();
            Console.Write("{0} -> ", flexibleNumber);
            for (int i = hexadecimalNumber.Count - 1; i >= 0; i--)
            {
                Console.Write(hexadecimalNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
