/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan		 George
	Peter		 Ivan
	Maria   ->   Maria
	George		 Peter
*/
using System;
using System.IO;
using System.Collections.Generic;

class SortingStrings
{
    static void Main()
    {
        //The .txt files are in the directory of the program
        List<string> strings = new List<string>();

        using (StreamReader unsortedStrings = new StreamReader(@"..\..\UnsortedStrings.txt"))
        {
            using (StreamWriter sortedStrings = new StreamWriter(@"..\..\SortedStrings.txt"))
            {
                string eachString = unsortedStrings.ReadLine();

                while (eachString != null)
                {
                    strings.Add(eachString);//Getting each string in the List of strings
                    eachString = unsortedStrings.ReadLine();
                }
                strings.Sort();//I sort the strings
            
                for (int i = 0; i < strings.Count; i++)
                {
                    sortedStrings.WriteLine(strings[i]);//Prints the strings in the file
                }
            }
        }
        Console.WriteLine("Done! Your sorted strings are in SortedStrings.txt in the directory of the program");
    }
}
