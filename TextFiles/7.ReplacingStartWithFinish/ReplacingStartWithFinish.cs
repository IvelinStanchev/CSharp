/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
 Ensure it will work with large files (e.g. 100 MB).*/
using System;
using System.IO;

class ReplacingStartWithFinish
{
    static void Main()
    {
        //The text files are in the directory of the program

        using (StreamReader textFile = new StreamReader(@"..\..\Text.txt"))
        {
            using (StreamWriter replacedFile = new StreamWriter(@"..\..\ReplacedFile.txt"))
            {
                string eachLine = textFile.ReadLine().ToLower();//.ToLower() will make the large letters to low ones
                while (eachLine != null)
                {
                    eachLine = eachLine.Replace("start", "finish").ToLower();
                    replacedFile.WriteLine(eachLine);
                    eachLine = textFile.ReadLine();
                }
            }
        }
        //If you want to replace the file uncomment the rows bellow. Otherwise the program will create a new file with the replaced substring
        //File.Replace(@"..\..\ReplacedFile.txt", @"..\..\Text.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! The File is replaced");
    }
}
