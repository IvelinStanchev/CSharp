/*Write a program that prints to the console which day of the week is today. Use System.DateTime.*/
using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime currentTime = DateTime.Now;
        string currentDay;
        currentDay = currentTime.DayOfWeek.ToString();
        Console.WriteLine("Today is {0}", currentDay);
    }
}
