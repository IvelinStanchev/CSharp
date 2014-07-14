/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 Write a program to test this method.*/
using System;

class PrintHelloAndName
{
    static void PrintName()
    {
        Console.Write("What is your name: ");
        string sayName = Console.ReadLine();
        Console.WriteLine("Hello, {0}", sayName);
    }

    static void Main()
    {
        PrintName();
    }
}
