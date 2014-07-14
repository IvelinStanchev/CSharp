/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/
using System;

class CheckingForLeapYear
{
    static void Main()
    {
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap;
        isLeap = DateTime.IsLeapYear(year);

        if (isLeap == true)
        {
            Console.WriteLine("The year is leap");
        }
        else
        {
            Console.WriteLine("The year is not leap");
        }
        
    }
}
