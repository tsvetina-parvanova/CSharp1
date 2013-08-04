//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_sArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter trapezoid`s first side:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter trapezoid`s second side:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter trapezoid`s height:");
            double height = double.Parse(Console.ReadLine());
            double area =( (sideA + sideB) / 2 )* height;
            Console.WriteLine("The trapezoid area is :" + area);

        }
    }
}
