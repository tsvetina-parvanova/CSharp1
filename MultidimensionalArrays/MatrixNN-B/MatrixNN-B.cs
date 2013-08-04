using System;

    class Program
    {

   static void Main()
    {
        Console.Write("Please enter size of matrix ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int counter = 0;
 
        counter = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int check = row & 1;
            if (check == 0)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    counter++;
                    matrix[column, row] = counter;
                }
            }
            else if (check == 1)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    counter++;
                    matrix[col, row] = counter;
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
  
