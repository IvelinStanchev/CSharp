/*Write a program that removes from a text file all words listed in given another text file. 
 Handle all possible exceptions in your methods.*/
using System;
using System.IO;
using System.Collections.Generic;

class RemovingWordsFromAnotherTextFile
{
    static void Main()
    {
        try
        {
            using (StreamReader mainText = new StreamReader(@"..\..\Text.txt"))
            {
                using (StreamReader wordsToBeRemoved = new StreamReader(@"..\..\WordsToBeRemoved.txt."))
                {
                    using (StreamWriter textWithoutTheGivenWords = new StreamWriter(@"..\..\NewFile.txt"))
                    {
                        List<string> wordsForRemoving = new List<string>();

                        string eachWordToBeRemoved = wordsToBeRemoved.ReadLine();
                        while (eachWordToBeRemoved != null)
                        {
                            wordsForRemoving.Add(eachWordToBeRemoved);
                            eachWordToBeRemoved = wordsToBeRemoved.ReadLine();
                        }

                        string[] allText = mainText.ReadToEnd().Split(' ');

                        bool flag = false;
                        for (int j = 0; j < allText.Length; j++)
                        {
                            for (int i = 0; i < wordsForRemoving.Count; i++)
                            {
                                //Finding all possible cases
                                if (allText[j].ToString() == wordsForRemoving[i])                      
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == wordsForRemoving[i].ToLower())
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("\r\n" + wordsForRemoving[i]))
                                {
                                    textWithoutTheGivenWords.Write("\r\n");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("\r\n" + wordsForRemoving[i].ToLower()))
                                {
                                    textWithoutTheGivenWords.Write("\r\n");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == (wordsForRemoving[i] + "."))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == (wordsForRemoving[i].ToLower() + "."))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == (wordsForRemoving[i] + ","))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == (wordsForRemoving[i].ToLower() + ","))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + wordsForRemoving[i]))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + wordsForRemoving[i].ToLower()))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + wordsForRemoving[i] + "."))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + wordsForRemoving[i].ToLower() + "."))
                                {
                                    textWithoutTheGivenWords.Write("");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + "\r\n" + wordsForRemoving[i]))
                                {
                                    textWithoutTheGivenWords.Write("\r\n");
                                    flag = true;
                                    break;
                                }
                                if (allText[j].ToString() == ("," + "\r\n" + wordsForRemoving[i].ToLower()))
                                {
                                    textWithoutTheGivenWords.Write("\r\n");
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                            {
                                textWithoutTheGivenWords.Write(allText[j] + " ");
                            }
                            flag = false;
                        }
                        textWithoutTheGivenWords.WriteLine();
                    }
                }
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null Argument");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong Argument");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory to file not exist");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not exist");
        }
        catch (IOException)
        {
            Console.WriteLine("File exception");
        }
        //I made the program to create a new file because it is more visible how it works but you can make it to rewrite on the current one just by uncomment the rows bellow
        //File.Replace(@"..\..\NewFile.txt", @"..\..\Text.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! You can see the new file in the directory of the program");
    }
}
