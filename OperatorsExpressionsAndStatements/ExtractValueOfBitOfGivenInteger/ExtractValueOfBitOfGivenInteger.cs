/*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n
  to hold the value v at the position p from the binary representation of n
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractValueOfBitOfGivenInteger
{
    class ExtractValueOfBitOfGivenInteger
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
            if (bit == 1)
                Console.WriteLine("The {0} bit is {1}",p,bit);
            else
                Console.WriteLine("The {0} bit is {1}",p,bit);
        }
    }
}
