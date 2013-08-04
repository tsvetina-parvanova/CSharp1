//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
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
            Console.WriteLine("Roots are: {0} and {1}",firstRoot,secondRoot);


        }
    }
}
