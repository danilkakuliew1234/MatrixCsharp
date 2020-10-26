﻿using System;
using System.Runtime.InteropServices;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            Console.WriteLine();
            int[,] MatrixOne = matrix.CreateMatrix(5, 5, -10, 10);
            matrix.DrawMatrix(MatrixOne);

            Console.WriteLine();
            int[,] MatrixTwo = matrix.CreateMatrix(5, 5, -10, 10);
            matrix.DrawMatrix(MatrixTwo);

            Console.WriteLine();
            int[,] summ = matrix.SummMatrix(MatrixOne, MatrixTwo);
            matrix.DrawMatrix(summ);
        }
    }
}
