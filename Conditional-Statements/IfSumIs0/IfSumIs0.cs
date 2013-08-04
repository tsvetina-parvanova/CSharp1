//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8  1+1-2=0.



using System;

class Subsets
{
    static void Main()
    {
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == 0)
                {
                    Console.WriteLine(array[i] + "+ " + array[j] + "=0");
                }
                for (int m = j + 1; m < array.Length; m++)
                {
                    if (array[i] + array[j] + array[m] == 0)
                    {
                        Console.WriteLine(array[i] + "+ " + array[j] + "+ " + array[m] + "=0");
                    }
                    for (int k = m + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[m] + array[k] == 0)
                        {
                            Console.WriteLine(array[i] + "+" + array[j] + "+" + array[m] + "+" + array[k] + "=0");
                        }
                        for (int l = m + 1; l < array.Length; l++)
                        {
                            if (array[i] + array[j] + array[m] + array[l] == 0)
                            {
                                Console.WriteLine(array[i] + "+" + array[j] + "+" + array[m] + "+" + array[k] + "+" + array[l] + "=0");
                            }
                        }
                    }
                }
            }
        }
    }
}

