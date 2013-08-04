//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;


namespace CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            double numberOne=1;
            int i=1;
            while (Math.Abs(numberOne)> 0.001)
            {
                Console.WriteLine("{0:F3}",numberOne);
                i++;
                numberOne = 1.0 / i;
                int sum = i % 2;
                if (sum == 1) { numberOne = -numberOne; }
                System.Threading.Thread.Sleep(500);
            }

        }
    }
}
