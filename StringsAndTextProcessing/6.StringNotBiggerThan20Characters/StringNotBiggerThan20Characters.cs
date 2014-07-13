/*Write a program that reads from the console a string of maximum 20 characters. 
 If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 Print the result string into the console.*/
using System;

class StringNotBiggerThan20Characters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        if (text.Length < 20)
        {
            for (int i = text.Length; i < 20; i++)
            {
                text += '*';//I use += because the operations are too low to use StringBuilder and its fast
            }
        }
        Console.WriteLine(text);
    }
}
