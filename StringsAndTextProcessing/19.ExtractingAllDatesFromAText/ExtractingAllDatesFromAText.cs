/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 Display them in the standard date format for Canada.*/
using System;
using System.Globalization;

class ExtractingAllDatesFromAText
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        string text = @"21.05.2013.
22.01.2013.
23 януари 2013- hey.
23.01.2013,
whats the date, 03.02.2013.";
        string[] words = text.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var word in words)
        {
            try
            {
                string wordWithoutDotAtTheEnd = word;
                if ((word[word.Length - 1] == '.'))//If the last symbol of each word is '.' I remove it
                {
                    wordWithoutDotAtTheEnd = word.Substring(0, word.Length - 1);
                }

                DateTime date = DateTime.ParseExact(wordWithoutDotAtTheEnd, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string dateAtCanada = date.ToString("dd/MM/yy", CultureInfo.InvariantCulture);
                Console.WriteLine(dateAtCanada);
            }
            catch (Exception)
            {
            }
        }
    }
}
