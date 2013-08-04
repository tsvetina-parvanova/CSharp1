using System;

class CatalanNumber
{
    static void Main(string[] args)
    {

        Console.Write("Please enter number n");
        int number = int.Parse(Console.ReadLine());
        decimal productOne = 1;
        decimal productTwo = 1;

        int numberPlusOne = number + 1;
        for (int i = 2 * number; i > numberPlusOne; i--)
        {
            productOne *= i; 
        }
        productTwo *= productOne;
        for (int i = 1; i <= number; i++)
        {
            productTwo /= i;
        }

        Console.WriteLine("Catalan number for number {0} is {1}", number,productTwo);
    }
}
