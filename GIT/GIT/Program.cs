using System;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[5, 5];
            Random randomNumber = new Random();
            for(int i = 0; i < Matrix.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = randomNumber.Next(0, 10);
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
