/*We are given integer number n, value v (v=0 or 1) and a position p. 
    Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	         n = 5 (00000101), p=2, v=0 -> 1 (00000001)
*/
using System;

class ChangingBinaryRepresentation
{
    static void Main()
    {
        Console.Write("Enter an integer number: "); //Example: 5
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");//Example: 3
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value (0 or 1): ");//Example: 1 or 0
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(Environment.NewLine);
        Console.Write("The number in binary representation is: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        int changingValues = 1;//Example: 000000001
        changingValues = changingValues << position;//Example: 000001000; move the digit 1 to position 'position'
        int finalNumber;
        if (value == 0)
        {
            finalNumber = (~(changingValues) & number);//   Example: 000000101 - the number 5 in binary representation
            Console.Write("The result is: ");//                      111110111 - this row of code changes the bit 0 to bit 1
            Console.Write(finalNumber + " ");//                      000000101 - we check with '&' number and changingValues
            Console.Write('(' + Convert.ToString(finalNumber, 2).PadLeft(8, '0') + ')');
        }
        else
        {
            finalNumber = (changingValues | number);//     Example: 000000000101 - the number in binary representation
            Console.Write("The result is: ");//                     000000001000 - changingValues after repositioning
            Console.Write(finalNumber + " ");//                     000000001101 - we check with '|' number and changingValues
            Console.Write('(' + Convert.ToString(finalNumber, 2).PadLeft(8, '0') + ')');
            Console.WriteLine(Environment.NewLine);
        }
    }
}

