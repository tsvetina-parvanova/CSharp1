using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter number n");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            for (int j = 1 + i; j <= number + i; j++)
            {
                Console.Write(j + "  ");
            }
            Console.WriteLine();
        }
    }
}