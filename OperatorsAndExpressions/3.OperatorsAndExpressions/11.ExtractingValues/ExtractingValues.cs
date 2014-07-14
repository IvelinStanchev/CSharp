/*Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.*/
using System;

class ExtractingValues
{
    static void Main()
    {
        Console.Write("Enter a number to check the bit position: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("The number in binary type is: ");
        Console.WriteLine(Convert.ToString(v, 2).PadLeft(8, '0'));
        Console.WriteLine(Environment.NewLine);
        Console.Write("Enter a bit position: ");// Here you must enter the number of bit positions you want to move
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        int checkBits = v & mask;
        if (checkBits == 0)
            Console.WriteLine("The bit at position '{0}' is 0", p);
        else
            Console.WriteLine("The bit at position '{0}' is 1", p);
    }
}
/*The position counts from 0. Example: 00000101
'1' is at the 0 position
'0' is at the 1 position
'1' is at the 2 position
'0' is at the 3 position*/
