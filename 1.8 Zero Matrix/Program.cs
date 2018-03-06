using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Zero_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 6] {
                                            { 0, 1, 1, 1, 1, 1 },
                                            { 2, 2, 2, 2, 2, 2 },
                                            { 3, 3, 0, 3, 3, 3 },
                                            { 4, 4, 4, 4, 4, 4 },
                                            { 5, 5, 5, 5, 5, 5 },
                                            { 6, 6, 6, 6, 6, 6 },
                                            { 7, 7, 7, 7, 0, 7 },
                                            { 8, 8, 8, 8, 8, 8 }
                                        };

            Console.WriteLine("Zero fill following matrix");
            printMatrix(matrix);

            int[,] zeroFilledMatrix = ZeroFill(matrix);

            Console.WriteLine("\nZero Filled");
            printMatrix(zeroFilledMatrix);

            Console.ReadLine();
        }

        private static int[,] ZeroFill(int[,] matrix)
        {
            List<int> zeroRows = new List<int>();
            List<int> zeroCols = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        zeroRows.Add(i);
                        zeroCols.Add(j);
                    }
                }
            }

            foreach (int row in zeroRows)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            foreach (int col in zeroCols)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = 0;
                }
            }

            return matrix;
        }

        private static void printMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
