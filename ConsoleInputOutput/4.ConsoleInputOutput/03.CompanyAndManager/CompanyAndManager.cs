/*A company has name, address, phone number, fax number, web site and manager. 
 The manager has first name, last name, age and a phone number.
 Write a program that reads the information about a company and its manager and prints them on the console.*/
using System;

class CompanyAndManager
{
    static void Main()
    {
        Console.Write("Please enter a name for the company: ");
        string nameCompany = Console.ReadLine();

        Console.Write("Please enter an address for the company: ");
        string addressCompany = Console.ReadLine();

        Console.Write("Please enter a phone number for the company: ");
        int phoneNumberComapy = int.Parse(Console.ReadLine());

        Console.Write("Please enter a fax number for the company: ");
        int faxNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter a web site for the company: ");
        string webSite = Console.ReadLine();

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(Environment.NewLine);

        Console.Write("Enter first name for the manager: ");
        string firstNameManager = Console.ReadLine();

        Console.Write("Enter last name for the manager: ");
        string lastNameManager = Console.ReadLine();

        Console.Write("Enter age for the manager: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter a phone number for the manager: ");
        int phoneNumberManager = int.Parse(Console.ReadLine());


        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(new string(((char)15), 50));//Adds a row of symbols with code '15'
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("The company information : ");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Name: {0}", nameCompany);
        Console.WriteLine("Address: {0}", addressCompany);
        Console.WriteLine("Phone number: {0}",phoneNumberComapy);
        Console.WriteLine("Fax number: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(new string(((char)18), 50));//Adds a row of symbols with code '18'
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("Personal information of the manager: ");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("First name: {0}", firstNameManager);
        Console.WriteLine("Last name: {0}", lastNameManager);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Phone number: {0}", phoneNumberManager);
    }
}

