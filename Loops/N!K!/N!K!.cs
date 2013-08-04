//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number n");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number k");
        int numberK = int.Parse(Console.ReadLine());
        int nFackt=1;
        int change;
        if (numberN < numberK)
        {
            change = numberN;
            numberN = numberK;
            numberK = change;
        }
        for (int i = numberK+1; i <= numberN; i++)
        {
            nFackt = nFackt * i;
        }
        Console.WriteLine(nFackt);
          
    }
}
