﻿/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
 We are living in an yellow submarine. We don't have anything else. 
 Inside the submarine is very tight. So we are drinking all the day. 
 We will move out of it in 5 days.
 
 The result is: 9.*/
using System;

class TimesASubstringIsContainingInAText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string searchingSubstring = "in";
        int repeatingTimes = 0;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text.Substring(i, searchingSubstring.Length).ToLower() == searchingSubstring)
            {
                repeatingTimes++;
                i += (searchingSubstring.Length - 1);
            }
        }
        Console.WriteLine("'{0}' is repeated {1} times", searchingSubstring, repeatingTimes);
    }
}
