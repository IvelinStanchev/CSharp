/*Write a program that reads the radius r of a circle and prints its perimeter and area.*/
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter, area;
        perimeter = 2 * Math.PI * radius;
        area = Math.PI * (radius * radius);

        Console.WriteLine("The perimeter is: {0}", perimeter);
        Console.WriteLine("The area is: {0}", area);
    }
}

