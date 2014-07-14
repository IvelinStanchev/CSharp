/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
Example: v=5; p=1 -> false.*/
using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter a number to check the bit at given position: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("The number in binary type is: ");
        Console.WriteLine(Convert.ToString(v, 2).PadLeft(8, '0'));
        Console.WriteLine(Environment.NewLine);
        Console.Write("Enter a bit position: ");// Here you must enter the number of bit positions you want to move
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        int checkBits = v & mask;
        bool isTrue = true;
        bool isFalse = false;
        if(checkBits == 0)
            Console.WriteLine("The bit at position '{0}' has value 1 -> {1}", p, isFalse);
        else
            Console.WriteLine("The bit at position '{0}' has value 1 -> {1}", p, isTrue);
    }
}
/*The position counts from 0. Example: 00000101
'1' is at the 0 position
'0' is at the 1 position
'1' is at the 2 position
'0' is at the 3 position*/

