//Write a program that enters the coefficients a, b and c of a quadratic equation
//	a*x2 + b*x + c = 0
//	and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class RootOfQuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a coefficient:");
        int aCoefficient = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter b coefficient:");
        int bCoefficient = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter c coefficient:");
        int cCoefficient = int.Parse(Console.ReadLine());

        double discriminant = (bCoefficient * bCoefficient) - (4 * aCoefficient * cCoefficient);
        if (discriminant < 0) { Console.WriteLine("There are not real roots"); }
        double firstRoot = (-bCoefficient + Math.Sqrt(discriminant)) / 2 * aCoefficient;
        double secondRoot = (-bCoefficient - Math.Sqrt(discriminant)) / 2 * aCoefficient;

        if(discriminant==0) {Console.WriteLine("The root is " + firstRoot);}
        else
            if (discriminant > 0)
            { Console.WriteLine("Roots are: {0} and {1}", firstRoot, secondRoot); }
    }
}


