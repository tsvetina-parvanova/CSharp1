//Write an expression that calculates rectangle’s area by given width and height.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_sArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter rectangle's width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter rectangle's height:");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("The rectangle`s area is :" + "  " + area);
        }
    }
}
