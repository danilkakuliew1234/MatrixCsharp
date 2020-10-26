using System;
using System.Runtime.InteropServices;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            
            int[,] MatrixOne = matrix.CreateMatrix(3, 3, -10, 10);
            matrix.DrawMatrix(MatrixOne);
            Console.WriteLine();

            int[,] MatrixTwo = matrix.CreateMatrix(3, 3, -10, 10);
            matrix.DrawMatrix(MatrixTwo);
            Console.WriteLine("\nMultiply");

            int[,] MultiplyMatrix = matrix.MultiplyMatrix(MatrixOne, MatrixTwo);
            matrix.DrawMatrix(MultiplyMatrix);
            Console.WriteLine("\nTake Away");

            int[,] TakeAway = matrix.TakeAwayMatrix(MatrixOne, MatrixTwo);
            matrix.DrawMatrix(TakeAway);
            Console.WriteLine();

        }
    }
}
