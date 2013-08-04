//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintsSumOf3IntegerNumbers
{
    class PrintsSumOf3IntegerNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum=firstNumber+secondNumber+thirdNumber;
            Console.WriteLine("The sum of the numbers is : " + sum);
        }
    }
}
