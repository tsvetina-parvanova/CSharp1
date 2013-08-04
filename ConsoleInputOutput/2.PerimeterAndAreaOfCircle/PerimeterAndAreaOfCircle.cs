//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;



class PerimeterAndAreaOfCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter radius of circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = 2 * Math.PI * radius * radius;
        Console.WriteLine("The perimeter of circle is:" + perimeter);
        Console.WriteLine("The area of circle is:" + area);
    }
}

