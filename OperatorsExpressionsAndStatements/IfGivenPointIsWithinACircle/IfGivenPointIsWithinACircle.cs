//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfGivenPointIsWithinACircle
{
    class IfGivenPointIsWithinACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x and y coordinates:");
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());
            if(
                (xCoordinate*xCoordinate + yCoordinate*yCoordinate)<=5*5   )
               
            Console.WriteLine("The point is within the circle");
            else Console.WriteLine("The point is out of the circle");

        }
    }
}
