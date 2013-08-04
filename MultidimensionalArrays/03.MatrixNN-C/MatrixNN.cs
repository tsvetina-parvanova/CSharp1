using System;

class MatrixNN
{
    static void Main()
    {
        Console.Write("Please enter size of matrix ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int count = 0;

        int countColumn = 2;
        int print = -1;
        count = 0;
        bool start = true;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            countColumn--;
            if (start == true)
            {
                for (int col = matrix.GetLength(1) - 1; col >= -1; col--)
                {
                    if (print <= 0)
                    {
                        count++;
                        matrix[col, row] = count;
                        print++;
                    }
                    else if (col < matrix.GetLength(1) - 2 && row < matrix.GetLength(0) - 1)
                    {
                        for (int i = 0; i < countColumn; i++)
                        {
                            count++;
                            matrix[col + 2 + i, row + 1 + i] = count;
                        }
                        print = 0;
                        if (col == -1)
                        {
                            start = false;
                            break;
                        }
                        col++;
                        countColumn++;
                    }
                }
            }

            else if (start == false)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (print <= 0)
                    {
                        count++;
                        matrix[col, row] = count;
                        print++;
                        if (count == n * n)
                        {
                            break;
                        }
                    }
                    else if (col < matrix.GetLength(1) && row < matrix.GetLength(0) - 1)
                    {
                        for (int i = 0; i < countColumn; i++)
                        {
                            count++;
                            matrix[col + i, row + 1 + i] = count;
                        }
                        print = 0;
                        if (col == 1)
                        {
                            start = false;
                            break;
                        }
                        col--;
                        countColumn--;
                    }
                }
            }
        }
        PrintArray(matrix);
    }

    private static void PrintArray(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
