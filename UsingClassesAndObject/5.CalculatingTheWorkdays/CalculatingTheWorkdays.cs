/*Write a method that calculates the number of workdays between today and given date, passed as parameter.
 Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/
using System;

class CalculatingTheWorkdays
{
    static void Main()
    {
        DateTime today = DateTime.Today;

        Console.Write("Enter the date you want to check in DD/MM/YYYY format: ");

        string[] finalDate = Console.ReadLine().Split('/');//.Split allows you to enter '/' between the string elements
        int day = int.Parse(finalDate[0]);
        int month = int.Parse(finalDate[1]);
        int year = int.Parse(finalDate[2]);

        DateTime finalDay = new DateTime(year, month, day);

        int workingDays = 0;

        int allDaysBetweenTodayAndEndDate;
        allDaysBetweenTodayAndEndDate = Math.Abs((finalDay - today).Days);

        DateTime[] holidays =
        {
            new DateTime(2013, 12, 25),
            new DateTime(2012, 01, 01),
            new DateTime(2013, 03, 03),
            new DateTime(2013, 11, 01),
            new DateTime(2013, 06, 01),
        };//These holidays are not the all ones but some

        bool isCurrentDayAHoliday = false;

        CalculatingTheWorkingdays(ref today, ref workingDays, allDaysBetweenTodayAndEndDate, holidays, ref isCurrentDayAHoliday);
        Console.WriteLine("The working days are: {0}", workingDays);
    }

    private static void CalculatingTheWorkingdays(ref DateTime today, ref int workingDays, int allDaysBetweenTodayAndEndDate, DateTime[] holidays, ref bool isCurrentDayAHoliday)
    {
        for (int i = 0; i < allDaysBetweenTodayAndEndDate; i++)//Checking every day between today and final day
        {
            today = today.AddDays(1);
            if ((today.DayOfWeek != DayOfWeek.Saturday) && (today.DayOfWeek != DayOfWeek.Sunday))//If the current day is not working day but it may be a holiday
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (today == holidays[j])//Checking if the current day is a holiday
                    {
                        isCurrentDayAHoliday = true;
                        break;//If so I go out of the loop
                    }
                }

                if (isCurrentDayAHoliday == false)
                {
                    workingDays++;//If the current day is not Saturday or Sunday and it is not a holiday that means that the day is workday
                }
                isCurrentDayAHoliday = false;
            }
        }
    }
}
