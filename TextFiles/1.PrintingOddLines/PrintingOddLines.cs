/*Write a program that reads a text file and prints on the console its odd lines.*/
using System;
using System.IO;
using System.Text;

class PrintingOddLines
{
    static void Main()
    {
        StreamReader readingFile = new StreamReader(@"..\..\TextFileOdd.txt");//The file is in the current program directory

        using (readingFile)
        {
            int lineNumber = 0;
            string line = readingFile.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber % 2) != 0)
                {
                    Console.WriteLine("Line {0}: {1}",
                    lineNumber, line);
                }
                line = readingFile.ReadLine();
            }
        }
    }
}

