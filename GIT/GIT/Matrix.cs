using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        public void DrawMatrix(int[,] Matrix, int MatrixNumber = 0)
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
        public int[,] SummMatrix(int[,] MatrixOne, int[,] MatrixTwo)
        {
            int[,] SummMatrix = new int[MatrixOne.GetLength(0), MatrixTwo.GetLength(1)];
            for (int i = 0; i < MatrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixTwo.GetLength(1); j++)
                {
                    SummMatrix[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
                }
            }
            return SummMatrix;
        }
        public int[,] MultiplyMatrix(int[,] MatrixOne, int[,] MatrixTwo)
        {
            int[,] MultiplyMatrix = new int[MatrixOne.GetLength(0), MatrixTwo.GetLength(1)];
            for(int i = 0; i < MatrixOne.GetLength(0); i++)
            {
                for(int j = 0; j < MatrixOne.GetLength(1); j++)
                {
                    for(int k = 0; k < MatrixOne.GetLength(0); k++)
                    {
                        MultiplyMatrix[i, j] = MatrixOne[i, k] * MatrixTwo[k, j];
                    }
                }
            }
            return MultiplyMatrix;
        }
        public int[,] TakeAwayMatrix(int[,] MatrixOne, int[,] MatrixTwo)
        {
            int[,] TakeAway = new int[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];

            for(int i = 0; i < MatrixOne.GetLength(0); i++)
            {
                for(int j = 0; j < MatrixOne.GetLength(1); j++)
                {
                    TakeAway[i, j] = MatrixOne[i, j] - MatrixTwo[i, j];
                }
            }
            return TakeAway;
        }
        public int[,] TranspositionMatrix(int[,] Matrix)
        {
            int[,] MatrixTranspostion = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
            for(int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++) 
                {
                    MatrixTranspostion[i, j] = Matrix[j, i];
                }
            }
            return MatrixTranspostion;
        }
    }
}
