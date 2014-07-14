/*Write a program that extracts from given XML file all the text without the tags. */
using System;
using System.IO;
using System.Text;

class ExtractingAllTextWithoutTheTags
{
    static void Main()
    {
        //The .xml file is in the directory of the program
        using (StreamReader xmlFile = new StreamReader(@"..\..\XML.xml"))
        {
            string line = xmlFile.ReadLine();

            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    StringBuilder currentTag = new StringBuilder();
                    if (line[i - 1] == '>')//If there is '>' I get the text after it while there is no '<'
                    {
                        while (line[i] != '<')
                        {
                            currentTag.Append(line[i]);
                            i++;
                        }

                        if (currentTag.ToString() != "")
                        {
                            Console.WriteLine(currentTag.ToString());
                        }
                    }
                }
                line = xmlFile.ReadLine();
            }
        }
    }
}
