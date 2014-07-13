/*Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
 We are living in a yellow submarine. 
 We don't have anything else. 
 Inside the submarine is very tight. 
 So we are drinking all the day. 
 We will move out of it in 5 days.
 
 The expected result is:
 We are living in a yellow submarine.
 We will move out of it in 5 days.
 
 Consider that the sentences are separated by "." and the words – by non-letter symbols.
 */
using System;
using System.Text;

class ExtractsSentencesContainingGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        StringBuilder eachSentence = new StringBuilder();
        string finalText = "";

        for (int i = 0; i < text.Length; i++)
        {
            bool isContaining = false;
            while (text[i] != '.')
            {
                eachSentence.Append(text[i]);
                if ((text[i] == word[0]) && (text[i + 1] == word[1]) && ((text[i + 2] == ' ') || (text[i + 2] == '.')))
                {
                    isContaining = true;
                }
                i++;
            }
            if (isContaining == true)
            {
                if (eachSentence[0] == ' ')
                {
                    eachSentence.Remove(0, 1);//I am removing the space in front of the sentence
                }
                finalText += eachSentence.ToString() + "." + '\n';
            }
            eachSentence = new StringBuilder();
        }
        Console.WriteLine(finalText);
    }
}
