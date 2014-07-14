using System;

class MarketingFirm
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your family name: ");
        string secondName = Console.ReadLine();
        Console.Write("What is your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("What is your gender - m(male) or f(female): ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Your ID number is: ");
        int idNumber = int.Parse(Console.ReadLine()); ;
        Console.Write("Enter your employee number (must be a number between 27560000 and 27569999): ");
        int uniqueNumber = int.Parse(Console.ReadLine());

        if (gender == 'm')
            gender = 'm';
        else if (gender == 'f')
            gender = 'f';
        else
            Console.WriteLine("Please re enter your gender");

        if ((uniqueNumber < 27560000) || (uniqueNumber > 27569999))
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please re enter the employee number");
        }
        else
        {
            Console.WriteLine(new string(' ', 50));
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string(' ', 50));
            Console.WriteLine("Your personal information is: ");
            Console.WriteLine(new string(' ', 50));
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Family name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("ID number: {0}", idNumber);
            Console.WriteLine("Employee number: {0}", uniqueNumber);
        }
    }
}

