/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.Write("Enter big base (a) of a trapezoid: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter small base (b) of a trapezoid: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height (h) of a trapezoid: ");
        double height = double.Parse(Console.ReadLine());
        double area = ((length + width) * height) / 2.0;
        Console.WriteLine("The trapezoid's area is: {0}", area);
    }
}
/*The decimal must be noted with ',' not with '.'*/

