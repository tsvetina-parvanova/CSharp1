//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number of the numbers you want to add:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter {0} numbers:",number);
            double sum=0;
            double[] array=new double[number];
            for (int i = 0; i < number; i++)   { array[i] = double.Parse(Console.ReadLine());
            sum = sum + array[i];
            }
            Console.WriteLine("The sum is " + (sum));
        }
    }
}
