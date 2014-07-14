using System;

class StringHelloWorld
{
    static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        object thirdVariable = firstVariable + "," + " " + secondVariable + "!"; ;
        string fourthVariable = (string)thirdVariable;
        Console.WriteLine(thirdVariable);
        Console.WriteLine(fourthVariable);
    }
}

