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
            int[,] matrix = new int[5, 5] {
                                            { 11, 12, 13, 14, 15 },
                                            { 21, 22, 23, 24, 25 },
                                            { 31, 32, 33, 34, 35 },
                                            { 41, 42, 43, 44, 45 },
                                            { 51, 52, 53, 54, 55 }
                                        };

            Console.WriteLine("Rotating following matrix");
            printMatrix(matrix);

            int[,] rotatedMatrix = RotateMatrix90ToRight(matrix);

            Console.WriteLine("\nRotated matrix (Not in place)");
            printMatrix(rotatedMatrix);

            Console.WriteLine("\nRotated matrix (In place)");
            RotateMatrix90ToRightInPlace(matrix);

            Console.ReadLine();
        }

        private static void RotateMatrix90ToRightInPlace(int[,] matrix)
        {
            int N = matrix.GetLength(0) - 1;
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                for (int j = i; j < N - i; j++)
                {
                    int lastValue = matrix[N - j, i];

                    matrix[N - j, i] = matrix[N - i, N - j];
                    matrix[N - i, N - j] = matrix[j, N - i];
                    matrix[j, N - i] = matrix[i, j];

                    matrix[i, j] = lastValue;
                }
            }

            printMatrix(matrix);

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
