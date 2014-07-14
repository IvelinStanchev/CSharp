using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i < 5; i += 2)
        {
            for (int j = 4; j >= i; j -= 2)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write('\u00A9');
            }

            Console.WriteLine();

        }
    }
}

