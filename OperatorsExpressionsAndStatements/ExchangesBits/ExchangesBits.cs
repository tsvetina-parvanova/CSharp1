using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangesBits
{
    class ExchangesBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            int firstPosition = 3;
            int secondPosition = 24;

            int firstMask = 7 << firstPosition;
            int secondMask = 7 << secondPosition;

            int getNumbers1 = number & firstMask;
            int getNumbers2 = number & secondMask;
            int change = (number & ~firstMask) & ~secondMask;

            int thirdMask = (getNumbers1 >>firstPosition) << secondPosition;
            int forthMask = (getNumbers2 >> secondPosition) << firstPosition;
            int result = (change | thirdMask) | forthMask;

            Console.WriteLine(result);
        }
    }
}
