//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

    class MatrixNN
    {
        static void Main()
        {
            Console.Write("Please enter matrix size ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int counter = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    counter++;
                    matrix[column, row] = counter;
                }
            }
            PrintArray(matrix);
        }

        private static void PrintArray(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("{0,3} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }