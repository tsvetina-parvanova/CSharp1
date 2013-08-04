//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators
//that modifies n to hold the value v at the position p from the binary representation of n
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiesNumerToHoldValue
{
    class ModifiesNumerToHoldValue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value 0 or 1:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter position of bit that you want to change:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());
            if (value == 1)
            {
                int mask = 1 << p;
                int result = number | mask;
                Console.WriteLine(result);
            }
            else
                if (value == 0)
                {
                    int mask = ~(1 << p);
                    int result = number & mask;
                    Console.WriteLine(result);
                }
                else Console.WriteLine("Error!");

        }
    }
}
