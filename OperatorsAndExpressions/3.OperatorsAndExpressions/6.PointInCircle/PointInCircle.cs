/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/
using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter a value for 'x': ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for 'y': ");
        double y = double.Parse(Console.ReadLine());
        double radius = 5;
        if((Math.Pow(x, 2) + Math.Pow(y, 2)) < (Math.Pow(radius, 2)))
            Console.WriteLine("The point is in the circle");
        else if((Math.Pow(x, 2) + Math.Pow(y, 2)) == (Math.Pow(radius, 2)))
            Console.WriteLine("The point lies on the circle");
        else
            Console.WriteLine("The point isn't in the circle");
    }
}

