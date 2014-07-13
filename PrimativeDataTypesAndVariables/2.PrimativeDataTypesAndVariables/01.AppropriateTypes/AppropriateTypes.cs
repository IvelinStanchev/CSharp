using System;

class AppropriateTypes
{
    static void Main()
    {
        ushort numUshort = 52130;
        sbyte numSbyte = -115;
        int numInt = 4825932;
        byte numByte = 97;
        short numShort = -10000;
        Console.WriteLine("The appropriate type for {0} is: ushort", numUshort);
        Console.WriteLine("The appropriate type for {0} is: sbyte", numSbyte);
        Console.WriteLine("The appropriate type for {0} is: int", numInt);
        Console.WriteLine("The appropriate type for {0} is: byte", numByte);
        Console.WriteLine("The appropriate type for {0} is: short", numShort);
    }
}

