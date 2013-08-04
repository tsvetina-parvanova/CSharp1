//Write an expression that checks if given integer is odd or even
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegerNumber
{
    class OddOrEvenIntegerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number:");
            int number= int.Parse(Console.ReadLine());
            if (number % 2 == 1) Console.WriteLine("The number is odd");
            else Console.WriteLine("The number is even");

        }
    }
}
