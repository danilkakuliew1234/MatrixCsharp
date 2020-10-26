using System;
using System.Collections.Generic;
using System.Text;

namespace GIT
{
    class Matrix
    {
        public int[,] CreateMatrix(int rows = 1, int cols = 1, int minNumber = -5, int maxNumber = 5)
        {
            int[,] Matrix = new int[rows, cols];
            Random RandomNumber = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = RandomNumber.Next(minNumber, maxNumber);
                }
            }
            return Matrix;
        }
        public void DrawMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
