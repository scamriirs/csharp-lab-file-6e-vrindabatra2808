//WAP to find the radius of circle, given its area.

using System;
class Finding_Radius
{
    static void Main(string[] args)
    {
        double area, radius;
        Console.WriteLine("Enter the area of the circle: ");
        area = Convert.ToDouble(Console.ReadLine());
        radius = Math.Sqrt(area / Math.PI);
        Console.WriteLine("Radius is: " + radius);
    }
}
