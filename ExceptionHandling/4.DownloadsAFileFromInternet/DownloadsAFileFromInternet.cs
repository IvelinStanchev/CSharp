/*Write a program that downloads a file from Internet 
 (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.*/
using System;
using System.Net;

class DownloadsAFileFromInternet
{
    static void Main()
    {
        Console.Write("Enter the url (Example: http://www.devbg.org/img/Logo-BASD.jpg): ");
        string url = Console.ReadLine();
        Console.WriteLine("The file is downloaded in the path C:\\DownloadedFile");

        WebClient downloading = new WebClient();
        try
        {
            downloading.DownloadFile(url, "C:\\DownloadFile");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please provide an url address!"); ;
        }
        catch (WebException)
        {
            Console.WriteLine("An error occurred while trying to download the file! Make sure the url is valid, the file you want to download exists and the internet connection is running!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The DownloadFile method cannot be called simultaneously on multiple threads.");
        }
        finally
        {
            downloading.Dispose();
            Console.WriteLine("Good bye!");
        }
    }
}
