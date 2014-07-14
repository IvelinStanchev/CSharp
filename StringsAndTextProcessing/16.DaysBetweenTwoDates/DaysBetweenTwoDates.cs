/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
 Enter the first date: 27.02.2006
 Enter the second date: 3.03.2004
 Distance: 4 days*/
using System;
using System.Globalization;

class DaysBetweenTwoDates
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first date in the format [day.month.year]: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date int the format [day.month.year]: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("The distance is: {0}", Math.Abs((firstDate - secondDate).Days));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format");
        }
    }
}
