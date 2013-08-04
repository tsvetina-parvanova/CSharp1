//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaxSum
    {
        static void Main()
        {

            Console.Write("Enter matrix rows:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix columns:");
            int k = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, k];
            int sum = 0, maxSum = int.MinValue;
            int row = 0, column = 0;
            int[,] arrSum = new int[3, 3];

            for (row = 0; row < n; row++)
            {
                for (column = 0; column < k; column++)
                {
                    Console.Write("Please enter element[{0},{1}]:", row + 1, column + 1);
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }
            if (n == 3 && k == 3)
                arrSum = matrix;

            for (row = 0; row < n; row++)
            {
                for (column = 0; column < k; column++)
                {
                    sum = 0;
                    int[,] arrTmp = new int[3, 3];
                    if (row + 2 < n && column + 2 < k)
                    {
                        for (int r = row, rt = 0; r <= row + 2; r++, rt++)
                        {
                            for (int c = column, ct = 0; c <= column + 2; c++, ct++)
                            {
                                sum += matrix[r, c];
                                arrTmp[rt, ct] = matrix[r, c];
                            }
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        arrSum = arrTmp;
                    }
                }
            }

            for (row = 0; row < 3; row++)
            {
                for (column = 0; column < 3; column++)
                {
                    Console.Write("{0, 3} ", arrSum[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum={0}", maxSum);
        }
    }
  