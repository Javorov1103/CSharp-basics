using System;

namespace MultiDemensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = new int[5,4];
            //int[,,] cube = new int[6, 8, 2];

            //int [,] matrix = 
            //{ 
            //    { 66,72,81,98,10},
            //    { 12,24,13,43,54},
            //    { 13,14,54,67,43}
            //};

            //int rows = matrix.GetLength(0);
            //int cols = matrix.GetLength(1);

            //Обикаляне на елементите на матрица/таблица/двуизмерен масив
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        int element = matrix[row, col];

            //        Console.WriteLine(element);
            //    }

            //    Console.WriteLine();
            //}

            //четене на матрица от конзолата

            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of cols");
            int cols = int.Parse(Console.ReadLine());

            //създавам матрицата със зададените параметри
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix");

            //пълним от конзолата
            for (int row = 0; row< rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine($"matrix[{row},{col}]:");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            //Разпечтвам матрицата
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
