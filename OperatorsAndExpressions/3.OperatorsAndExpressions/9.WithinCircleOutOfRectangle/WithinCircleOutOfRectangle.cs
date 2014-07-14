/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and 
out of the rectangle R(top=1, left=-1, width=6, height=2).*/
using System;

class WithinCircleOutOfRectangle
{
    static void Main()
    {
        Console.Write("Enter a value for 'x' (point(x,y)): ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for 'y' (point(x,y)): ");
        double pointY = double.Parse(Console.ReadLine());
        double radius = 3;
        double centerX = 1;
        double centerY = 1;

        if ((((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius * radius)) ||
            ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1)))

            Console.WriteLine("The point({0}, {1}) is within the circle and rectangle", pointX, pointY);

        else

            Console.WriteLine("The point({0}, {1}) is out of the circle and rectangle", pointX, pointY);

    }
}

