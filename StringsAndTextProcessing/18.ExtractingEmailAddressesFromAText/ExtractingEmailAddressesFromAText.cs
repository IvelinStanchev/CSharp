/*Write a program for extracting all email addresses from given text. 
 All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
using System;
using System.Text;

class ExtractingEmailAddressesFromAText
{
    static void Main()
    {
        string text = "using System; afasf@gmail.com,static void Main() extracting email!asfss@yahoo.com!";
        StringBuilder reversedEmail = new StringBuilder();
        StringBuilder realEmail = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            int counter = i;
            
            //I am getting the words before and after the sybol '@'
            if (text[counter] == '@')
            {
                while ((text[counter] != ' ') && (text[counter] != ',') && (text[counter] != '?') && (text[counter] != '!') && (text[i] != '[') && (text[counter] != ']') && (text[counter] != '{') && (text[counter] != '}') && (text[counter] != '+') && (text[counter] != '*') && (text[counter] != '=') && (text[counter] != '-'))
                {
                    reversedEmail.Append(text[counter]);
                    counter--;
                }
                for (int j = reversedEmail.Length - 1; j >= 0; j--)
                {
                    realEmail.Append(reversedEmail[j]);
                }
                counter = i + 1;
                
                while ((text[counter] != ' ') && (text[counter] != ',') && (text[counter] != '?') && (text[counter] != '!') && (text[i] != '[') && (text[counter] != ']') && (text[counter] != '{') && (text[counter] != '}') && (text[counter] != '+') && (text[counter] != '*') && (text[counter] != '=') && (text[counter] != '.'))
                {
                    realEmail.Append(text[counter]);
                    counter++;
                }
                realEmail.Append('.');
                counter++;
                while ((text[counter] != ' ') && (text[counter] != ',') && (text[counter] != '?') && (text[counter] != '!') && (text[i] != '[') && (text[counter] != ']') && (text[counter] != '{') && (text[counter] != '}') && (text[counter] != '+') && (text[counter] != '*') && (text[counter] != '=') && (text[counter] != '.'))
                {
                    realEmail.Append(text[counter]);
                    counter++;
                }
                Console.WriteLine(realEmail);
            }
            reversedEmail = new StringBuilder();
            realEmail = new StringBuilder();
        }
    }
}
