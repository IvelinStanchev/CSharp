/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
 The tags cannot be nested. Example:
 We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 
 The expected result:
 We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */
using System;
using System.Text;

class MakingTheWordsInTheTagsToUppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder textWithUppercasedWords = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] == '<'))
            {
                i += 8;

                while (text[i] != '<')
                {
                    textWithUppercasedWords.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += 8;//I want to escape the "</upcase>"
            }
            else
            {
                textWithUppercasedWords.Append(text[i]);
            }
        }
        Console.WriteLine(textWithUppercasedWords.ToString());
    }
}
