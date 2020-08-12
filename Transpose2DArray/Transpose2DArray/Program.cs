using System;

namespace Transpose2DArray
{
    /// <summary>
    /// Program to demonstrate Transpose a matrix of given dimensions
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsNCols = Console.ReadLine().Split(' ');

            int rows = Convert.ToInt32(rowsNCols[0]);
            int cols = Convert.ToInt32(rowsNCols[1]);
            int[,] inputArr = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                var rowData = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    inputArr[i, j] = Convert.ToInt32(rowData[j]);
                }
            }

            Transpose(inputArr, rows, cols);

            Console.ReadLine();
        }

        static void Transpose(int[,] inputArr, int rowNum, int colNum)
        {
            for (int i = 0; i < colNum; i++)
            {
                for (int j = 0; j < rowNum; j++)
                {
                    Console.Write(string.Format("{0} ", inputArr[j, i]));
                }
                Console.WriteLine();
            }
        }
    }
}
