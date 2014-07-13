/*Write a program that compares two text files line by line and prints the number of lines 
 that are the same and the number of lines that are different. Assume the files have equal number of lines.*/
using System;
using System.IO;
using System.Collections.Generic;

class ComparingTwoFilesLineByLine
{
    static void Main()
    {
        StreamReader firstText = new StreamReader(@"..\..\FirstFile.txt");
        StreamReader secondText = new StreamReader(@"..\..\SecondFile.txt");

        Console.WriteLine("First text: ");
        string printFirstText = File.ReadAllText(@"..\..\FirstFile.txt");
        Console.WriteLine(printFirstText);
        Console.WriteLine();
        Console.WriteLine("Second text: ");
        string printSecondText = File.ReadAllText(@"..\..\SecondFile.txt");
        Console.WriteLine(printSecondText);
        List<string> sameLinesAsString = new List<string>();

        int sameRows = 0;
        int allRows = 0;

        using (firstText)
        {
            using (secondText)
            {
                string firstTextRow = firstText.ReadLine();
                string secondTextRow = secondText.ReadLine();

                while (firstTextRow != null)//It could be secondTextRow but they are with same rows so it doesn't matter
                {
                    allRows++;
                    if (firstTextRow == secondTextRow)
                    {
                        sameRows++;
                        sameLinesAsString.Add(firstTextRow);
                    }

                    firstTextRow = firstText.ReadLine();
                    secondTextRow = secondText.ReadLine();
                }
            }
        }

        Console.WriteLine("{0} rows are the same: ", sameRows);

        for (int i = 0; i < sameLinesAsString.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(sameLinesAsString[i]);
        }
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("There are {0} different rows", allRows - sameRows);
    }
}
