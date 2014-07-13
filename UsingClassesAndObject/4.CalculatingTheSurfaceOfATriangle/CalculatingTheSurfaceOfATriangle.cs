/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/
using System;

class CalculatingTheSurfaceOfATriangle
{
    static void Main()
    {
        Console.WriteLine("Calculating the surface by one side and an altitude to it");
        Console.Write("Enter the side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter the altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        double surfaceBySideAndAltitude;
        surfaceBySideAndAltitude = CalculatingSurfaceByOneSideAndAnAltitude(firstSide, altitude);

        Console.WriteLine("The surface by one side and an altitude to it is: {0}", surfaceBySideAndAltitude);

        PrintingDashes();

        Console.WriteLine("Calculating the surface by three sides");
        Console.WriteLine("First side: {0}", firstSide);
        Console.Write("Enter the second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter the third side: ");
        double thirdSide = double.Parse(Console.ReadLine());

        double perimeter;
        perimeter = firstSide + secondSide + thirdSide;
        double surfaceByThreeSides;
        surfaceByThreeSides = CalculatingSurfaceByThreeSides(firstSide, secondSide, thirdSide, perimeter);//I use the Heron's formula
        Console.WriteLine("The surface of the triangle by three sides is: {0}", surfaceByThreeSides);

        PrintingDashes();

        Console.WriteLine("Calculating the surface by two sides and an angle between them");
        Console.WriteLine("First side: {0}", firstSide);
        Console.WriteLine("Second side: {0}", secondSide);
        Console.Write("Enter an angle: ");
        int angle = int.Parse(Console.ReadLine());
        double angleInRadians;
        angleInRadians = angle * Math.PI / 180;//I make the entered angle in radians because of the Math.Sin formula
        double surfaceByTwoSidesAndAnAngle;
        surfaceByTwoSidesAndAnAngle = CalculatingSurfaceByTwoSidesAndAnAngleBetweenThem(firstSide, secondSide, angleInRadians);
        Console.WriteLine("The surface of the triangle by two sides and an angle between them is: {0}", surfaceByTwoSidesAndAnAngle);
    }

    private static void PrintingDashes()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();
    }

    private static double CalculatingSurfaceByTwoSidesAndAnAngleBetweenThem(double firstSide, double secondSide, double angleInRadians)
    {
        double surfaceByTwoSidesAndAnAngle;
        surfaceByTwoSidesAndAnAngle = (firstSide * secondSide * Math.Sin(angleInRadians)) / 2;
        return surfaceByTwoSidesAndAnAngle;
    }

    private static double CalculatingSurfaceByThreeSides(double firstSide, double secondSide, double thirdSide, double perimeter)
    {
        double surfaceByThreeSides;
        surfaceByThreeSides = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
        return surfaceByThreeSides;
    }

    private static double CalculatingSurfaceByOneSideAndAnAltitude(double firstSide, double altitude)
    {
        double surfaceBySideAndAltitude;
        surfaceBySideAndAltitude = (firstSide * altitude) / 2;
        return surfaceBySideAndAltitude;
    }
}
