using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Rotate_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4] {
                                            { 10, 11, 12, 13 },
                                            { 20, 21, 22, 23 },
                                            { 30, 31, 32, 33 },
                                            { 40, 41, 42, 43 }
                                        };

            Console.WriteLine("Rotating following matrix");
            printMatrix(matrix);

            int[,] rotatedMatrix = RotateMatrix90ToRight(matrix);

            Console.WriteLine("Rotated matrix");
            printMatrix(rotatedMatrix);

            Console.ReadLine();
        }

        private static int[,] RotateMatrix90ToRight(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[j, matrix.GetLength(0) - 1 - i] = matrix[i, j];
                }
            }

            return result;
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
