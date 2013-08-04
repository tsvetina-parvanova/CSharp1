//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointsOfCircleAndRectangle
{
    class CheckPointsOfCircleAndRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x and y coordinate:");
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());
            if(Math.Pow(xCoordinate-1,2) + Math.Pow(yCoordinate-1,2)<=3*3)
                Console.WriteLine("The point is within circle ((1,1),3)");
            else
                Console.WriteLine("The cpoint is out of circle ((1,1),3)");
            if (xCoordinate >= -1 && xCoordinate <= 5 && yCoordinate >= -1 && yCoordinate <= 1)
                Console.WriteLine("The point is within rectangle R(top=1, left=-1, width=6, height=2).");
            else
                Console.WriteLine("The point is out of rectangle R(top=1, left=-1, width=6, height=2).");




        }
    }
}
