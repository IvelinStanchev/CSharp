/*Write a program that deletes from a text file all words that start with the prefix "test". 
 Words contain only the symbols 0...9, a...z, A…Z, _.*/
using System;
using System.IO;

class DeletingAllWordsStartingWithThePrefixTest
{
    static void Main()
    {
        using (StreamReader words = new StreamReader (@"..\..\ContainingWords.txt"))
        {
            using (StreamWriter wordsWithoutTest = new StreamWriter(@"..\..\NewFile.txt"))
            {
                string line = words.ReadLine();

                while (line != null)
                {
                    if ((line[0] != 't') || (line[1] != 'e') || (line[2] != 's') || (line[3] != 't'))
                    {
                        wordsWithoutTest.WriteLine(line);
                    }
                    line = words.ReadLine();
                }
            }
        }
        //I made the program to create a new file because it is more visible how it works but you can make it to rewrite on the current one just by uncomment the rows bellow
        //File.Replace(@"..\..\NewFile.txt", @"..\..\ContainingWords.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! You can see the file in the directory of the program");
    }
}