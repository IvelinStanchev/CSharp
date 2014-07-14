using System;
using System.Windows.Forms;

class OutOfConsoleMessageBox
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 5)
            {
                Console.WriteLine("Yes! Your number is bigger than 5");
            }
        }
        catch
        {
            MessageBox.Show("Error!\nOver flow exception");
        }
    }
}

