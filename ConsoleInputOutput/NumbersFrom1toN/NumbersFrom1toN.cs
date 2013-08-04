//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
//each on a single line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter a number:");
                int number = int.Parse(Console.ReadLine());
                for (int i = 1; i <= number; i++) { Console.Write(i + " "); }
                 
            }
        }
    }
}
