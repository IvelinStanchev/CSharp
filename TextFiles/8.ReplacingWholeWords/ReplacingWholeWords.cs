/*Modify the solution of the previous problem to replace only whole words (not substrings).*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplacingWholeWords
{
    static void Main()
    {
        using (StreamReader readTheFile = new StreamReader(@"..\..\Text.txt"))
        {
            using (StreamWriter reWriteTheFile = new StreamWriter(@"..\..\ReplacedWords.txt"))
            {
                string line = readTheFile.ReadLine();

                while (line != null)
                {
                    line = Regex.Replace(line, @"\bstart\b", "finish");//I use regular expressions
                    reWriteTheFile.WriteLine(line);
                    line = readTheFile.ReadLine();
                }
            }
        }
        //If you want to replace the file uncomment the rows bellow. Otherwise the program will create a new file with the replaced substring
        //File.Replace(@"..\..\ReplacedWords.txt", @"..\..\Text.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! You can see the replaced file in the directory of the program");
    }
}
