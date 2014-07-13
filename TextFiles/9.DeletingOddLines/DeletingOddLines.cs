/*Write a program that deletes from given text file all odd lines. The result should be in the same file.*/
using System;
using System.IO;

class DeletingOddLines
{
    static void Main()
    {
        
        using (StreamReader readAllText = new StreamReader(@"..\..\TextWithAllLines.txt"))
        {
            using (StreamWriter textWithoutOddLines = new StreamWriter(@"..\..\TextWithoutOddLines.txt"))
            {
                int lineNumber = 0;
                string currentLine = readAllText.ReadLine();
                while (currentLine != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)//If the current line is even I add it
                    {
                        textWithoutOddLines.Write(lineNumber + ". ");
                        textWithoutOddLines.WriteLine(currentLine);
                    }
                    else//If the current line is odd I just print new row
                    {
                        textWithoutOddLines.Write(lineNumber + ". ");
                        textWithoutOddLines.WriteLine();
                    }
                    currentLine = readAllText.ReadLine();
                }
            }
        }

        //I made the program to create a new file because it is more visible how it works but you can make it to rewrite on the current one just by uncomment the rows bellow
        //File.Replace(@"..\..\TextWithoutOddLines.txt", @"..\..\TextWithAllLines.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! You can see the file in the directory of the program");
    }
}
