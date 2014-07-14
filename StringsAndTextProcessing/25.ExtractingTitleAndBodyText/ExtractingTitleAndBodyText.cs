/*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
 <html>
  <head><title> News </title></head>
  <body><p><a href="http://academy.telerik.com"> Telerik
    Academy </a> aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers. </p></body>
</html>*/
using System;

class ExtractingTitleAndBodyText
{
    static void Main()
    {
        string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a> aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";
        string textWithoutText = "";
        for (int i = 0; i < text.Length - 10; i++)
        {
            if ((text[i] == '>'))
            {
                i++;
                while (text[i] != '<')
                {
                    textWithoutText += text[i];
                    i++;
                }
            }
        }
        Console.WriteLine(textWithoutText);
    }
}
