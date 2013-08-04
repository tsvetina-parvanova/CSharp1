//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number n");
        int numberN=int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number x");
        int numberX=int.Parse(Console.ReadLine());
        double sum = 1;
        double FacktN = 1;

        for (int i = 1; i <= numberN; i++)
        {
            numberX = (int)Math.Pow(numberX, i);
            FacktN *= i;
            sum += FacktN / numberX;
        }
        Console.WriteLine(sum);
    }
}
