/*Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time 
 after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/
using System;
using System.Globalization;

class PrintingTheTimeAfterAWhile
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the date and time in the format [d.MM.yyyy HH:mm:ss]: ");
            string enteringDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(enteringDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            DateTime newDate = date.AddHours(6.5);

            Console.WriteLine("Your date: {0} - {1}", enteringDate, date.DayOfWeek);
            Console.WriteLine("Your date after 6 hours and 30 minutes: {0} - {1}", newDate, newDate.DayOfWeek);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format");
        }
    }
}
