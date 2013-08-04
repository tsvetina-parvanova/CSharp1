//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsGreaterNumber
{
    class PrintsGreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNumber, secondNumber));



        }
    }
}
