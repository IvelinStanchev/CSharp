/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.*/
using System;

class ThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number to check the third bit: ");
        int binaryNumber = int.Parse(Console.ReadLine());
        int secondBinaryNumber = binaryNumber;
        Console.Write("The number in binary type is: ");
        Console.WriteLine(Convert.ToString(secondBinaryNumber, 2).PadLeft(10, '0'));
        int bits = 3;
        int mask = 1;
        mask = mask << bits;
        int checks = binaryNumber & mask;
        if (checks == 0)
            Console.WriteLine("The third bit is: 0");
        else
            Console.WriteLine("The third bit is: 1");
    }
}
/*The position counts from 0. Example: the number 12345 has third digit 2 counting from right-to-left.
'5' is at the 0 position
'4' is at the 1 position
'3' is at the 2 position
'2' is at the 3 position
The needed position is 3*/


