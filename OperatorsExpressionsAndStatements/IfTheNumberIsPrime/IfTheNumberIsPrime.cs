//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTheNumberIsPrime
{
    class IfTheNumberIsPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number from 1 to 100");
            int number = int.Parse(Console.ReadLine());
            if (number == 2 || number == 3 || number == 5 || number == 7)
            { Console.WriteLine("The number is prime"); }
            else
                if (number != 2 && number != 3 && number != 5 && number != 7)
                {
                    if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
                        Console.WriteLine("The number is prime");
                    else Console.WriteLine("The number is not prime");
                }

        }
    }
}
