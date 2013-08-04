using System;

    class EqualStrings
    {
         static void Main(string[] args)
        {
            string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };

            int maxSequence = 1;
            int currentSequence = 1;
            string maxElement = "element";
            int direction = 0;
 
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    if (matrix[rows, column] == matrix[rows, column + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }
 
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxElement = matrix[rows, column];
                        direction = 1;
                    }
                }
                currentSequence = 1;
            }
 
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }
 
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxElement = matrix[rows, cols];
                        direction = 2;
                    }
                }
                currentSequence = 1;
            }
 
            
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                    {
                        if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                        {
                            currentSequence++;
                        }
                        else
                        {
                            currentSequence = 1;
                        }
 
                        if (maxSequence < currentSequence)
                        {
                            maxSequence = currentSequence;
                            maxElement = matrix[rows, cols];
                            direction = 3;
                        }
                    }
                    currentSequence = 1;
                }
            }
 

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                        {
                            currentSequence++;
                        }
                        else
                        {
                            currentSequence = 1;
                        }
 
                        if (maxSequence < currentSequence)
                        {
                            maxSequence = currentSequence;
                            maxElement = matrix[rows, cols];
                            direction = 4;
                        }
                    }
                    currentSequence = 1;
                }
            }
 
            switch (direction)
            {
                case 1:
                    Console.WriteLine("The word \"{0}\" repeats {1} times horizontally.", maxElement, maxSequence);
                    break;
                case 2:
                    Console.WriteLine("The word \"{0}\" repeats {1} times vertically.", maxElement, maxSequence);
                    break;
                case 3:
                    Console.WriteLine("The word \"{0}\" repeats {1} times diagonally from top left to bottom right.", maxElement, maxSequence);
                    break;
                case 4:
                    Console.WriteLine("The word \"{0}\" repeats {1} times diagonally from top right to bottom left.", maxElement, maxSequence);
                    break;
                default:
                    Console.WriteLine("No repetitions of elements.");
                    break;
            }
        }
    }

