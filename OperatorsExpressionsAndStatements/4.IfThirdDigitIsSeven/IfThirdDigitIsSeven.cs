//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class IfThirdDigitIsSeven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please eneter number:");
        int number = int.Parse(Console.ReadLine());
        int thirdNumber = (number % 1000 )/100;
        if (thirdNumber == 7) Console.WriteLine("The third digit from right to left is 7.");
        else Console.WriteLine("The third digit from right to left is NOT 7.");
        
    }
}

