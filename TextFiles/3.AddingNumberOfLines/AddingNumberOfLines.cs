/*Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 The result should be written to another text file.*/
using System;
using System.IO;

class AddingNumberOfLines
{
    static void Main()
    {
        StreamReader text = new StreamReader(@"..\..\AddingNumberOfLines.cs");
        StreamWriter linedText = new StreamWriter(@"..\..\LinedText.txt");

        using (linedText)
        {
            string lineText = text.ReadLine();
            int lineNumber = 0;
            while (lineText != null)
            {
                lineNumber++;
                linedText.Write(lineNumber + ". " + lineText);
                linedText.WriteLine();
                lineText = text.ReadLine();
            }
        }
        Console.WriteLine("Done! You can see the text in LinedText.txt in the program directory");
    }
}
