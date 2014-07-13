/*Write a program that concatenates two text files into another text file.*/
using System;
using System.IO;

class ConcatenatingTwoFilesIntoAnother
{
    static void Main()
    {
        //The files are in the directory of the program
        StreamReader firstFile = new StreamReader(@"..\..\FirstFile.txt");
        StreamReader secondFile = new StreamReader(@"..\..\SecondFile.txt");
        StreamWriter concatenatedFile = new StreamWriter(@"..\..\Concatenated files.txt");

        using (firstFile)
        {
            using (secondFile)
            {
                using (concatenatedFile)
                {
                    string firstText = firstFile.ReadToEnd();
                    string secondText = secondFile.ReadToEnd();

                    concatenatedFile.Write(firstText);
                    concatenatedFile.WriteLine();
                    concatenatedFile.Write(secondText);
                }
            }
        }
        Console.WriteLine("Done! Search in the program directory for Concatenated files.txt");
    }
}
