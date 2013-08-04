//Write a program to print the first 100 members of the sequence of 
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            decimal numberOne = 0;
            decimal numberTwo = 1;
            decimal sum=0;
            for (int i = 0; i <= 100; i++)
            { Console.WriteLine(numberOne);
            sum = numberOne + numberTwo;
            numberOne = numberTwo;
            numberTwo = sum;
            }

        }
    }
}

