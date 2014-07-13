/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 Be sure to catch all possible exceptions and print user-friendly error messages.*/
using System;
using System.IO;
using System.Security;

class Test
{
    public static void Main()
    {
        //Be sure you enter a path that contains a file. Example: if you have a folder called Test in your C:\ disk and in this folder there is a .txt file called MyTest
        //you must enter that path: C:\Test\MyTest.txt 
        Console.Write("Enter the path (For example: C:\\WINDOWS\\win.txt): ");
        try
        {
            string enterPath = Console.ReadLine();
            string readText = File.ReadAllText(enterPath);//Tries to open the file
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path doesn't containing characters, contains only spaces,\nor contains one or more invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid or the directory cannot be found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
    }
}
