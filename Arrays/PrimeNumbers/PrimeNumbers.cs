//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int[] array = new int[5000001];
            array[0] = 0;
            for (int i = 1, j = 1; i < 5000001; i++, j += 2) 
            {
                array[i] = j;
            }
            Console.Write(array[1] + " ");
            for (int i = 2; i <= 1582; i++)                                       
            {
                if (array[i] != 0)             
                {
                    for (int j = i + 1; j < 5000001; j++)
                    {
                        if (array[j] % array[i] == 0)
                        {
                            array[j] = 0;
                        }
                    }
                    Console.Write(array[i] + " ");
                }
            }
            for (int i = 1582; i < 5000001; i++) 
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }