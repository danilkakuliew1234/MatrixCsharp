using Matrix;
using System;
using System.Runtime.InteropServices;
using Matrix;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOne = Matrix.Matrix.CreateMatrix(3, 3, -10, 10);
            Matrix.Matrix.DrawMatrix(arrayOne);
        }
    }
}
