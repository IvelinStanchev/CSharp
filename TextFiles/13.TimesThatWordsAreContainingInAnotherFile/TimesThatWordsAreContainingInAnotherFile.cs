/*Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file 
 test.txt. The result should be written in the file result.txt and the words 
 should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.*/
using System;
using System.IO;
using System.Collections.Generic;

class TimesThatWordsAreContainingInAnotherFile
{
    static void Main()
    {
        try
        {
            using (StreamReader words = new StreamReader(@"..\..\words.txt"))
            {
                using (StreamReader text = new StreamReader(@"..\..\text.txt."))
                {
                    using (StreamWriter result = new StreamWriter(@"..\..\result.txt"))
                    {
                        List<string> wordsInList = new List<string>();

                        string line = words.ReadLine();
                        while (line != null)
                        {
                            wordsInList.Add(line);
                            line = words.ReadLine();
                        }
                        int[] countingRepeatingTimes = new int[wordsInList.Count];

                        string[] allText = text.ReadLine().Split();
                        int counter = 0;

                        for (int i = 0; i < wordsInList.Count; i++)
                        {
                            for (int j = 0; j < allText.Length; j++)
                            {
                                //Finding all possible cases
                                if (allText[j] == wordsInList[i])
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == wordsInList[i].ToLower())
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("\r\n" + wordsInList[i]))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("\r\n" + wordsInList[i].ToLower()))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == (wordsInList[i] + "."))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == (wordsInList[i].ToLower() + "."))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == (wordsInList[i] + ","))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == (wordsInList[i].ToLower() + ","))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + wordsInList[i]))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + wordsInList[i].ToLower()))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + wordsInList[i] + "."))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + wordsInList[i].ToLower() + "."))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + "\r\n" + wordsInList[i]))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                                if (allText[j] == ("," + "\r\n" + wordsInList[i].ToLower()))
                                {
                                    counter++;
                                    countingRepeatingTimes[i] = counter;
                                }
                            }
                            counter = 0;
                        }

                        string[] wordsInDescendingOrder = new string[wordsInList.Count];
                        int[] repeatingTimes = new int[wordsInList.Count];
                        

                        for (int i = 0; i < wordsInList.Count - 1; i++)
                        {
                            int theBiggestIndexOfTheRest = i;
                            int swap = int.MinValue;
                            string swapForStrings = "";

                            for (int j = i + 1; j < wordsInList.Count; j++)
                            {
                                if (countingRepeatingTimes[j] > countingRepeatingTimes[i])
                                {
                                    theBiggestIndexOfTheRest = j;
                                    swap = countingRepeatingTimes[theBiggestIndexOfTheRest];
                                    countingRepeatingTimes[theBiggestIndexOfTheRest] = countingRepeatingTimes[i];
                                    countingRepeatingTimes[i] = swap;

                                    swapForStrings = wordsInList[theBiggestIndexOfTheRest];
                                    wordsInList[theBiggestIndexOfTheRest] = wordsInList[i];
                                    wordsInList[i] = swapForStrings;
                                }
                            }
                        }

                        //I get the result in a new file which is called result.txt in the directory of the program
                        for (int i = 0; i < wordsInList.Count; i++)
                        {
                            result.WriteLine(wordsInList[i] + " -> " + countingRepeatingTimes[i] + " times");
                        }
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
        //File.Replace(@"..\..\result.txt", @"..\..\text.txt", @"..\..BackUpFile.txt");
        //File.Delete("../../BackUpFile.txt");
        Console.WriteLine("Done! You can see the new file in the directory of the program");
    }
}
