using System;



    class Program
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal numerator = (n*n) + (1 / (m * p) + 1337);

        }
    }

