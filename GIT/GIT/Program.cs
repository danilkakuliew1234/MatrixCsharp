using System;
using System.Runtime.InteropServices;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();


            int[,] Matrix = matrix.CreateMatrix(3, 3, -10, 10);
            matrix.DrawMatrix(Matrix);

            Console.WriteLine("\nTransposition matrix");
            matrix.DrawMatrix(matrix.TranspositionMatrix(Matrix));

        }
    }
}
