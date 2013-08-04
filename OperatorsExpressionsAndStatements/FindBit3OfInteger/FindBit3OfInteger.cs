//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBit3OfInteger
{
    class FindBit3OfInteger
    {
        static void Main(string[] args)
        {
            int p = 3;
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());               
            int mask = 1 << p;        
            int numberAndMask = number & mask;  
            int bit = numberAndMask >> p;  
            Console.WriteLine("The third bit is :" + bit);   

        }
    }
}
