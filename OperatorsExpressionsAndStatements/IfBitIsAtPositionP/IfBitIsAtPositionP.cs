//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfBitIsAtPositionP
{
    class IfBitIsAtPositionP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a position of bit that you want to check:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number:");
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> p;
            if(bit==1)
            Console.WriteLine("true" ); 
            else
                Console.WriteLine("false");

        }
    }
}
