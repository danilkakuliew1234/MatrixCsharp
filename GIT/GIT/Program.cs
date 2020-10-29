using Matrix;
using System;
using System.Runtime.InteropServices;
using Matrix;
using Tasks;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(task2(10));
        }
        public static float task1()
        {
            int i = 1;
            int _exp = 2;
            int degree = 2;
            int z = -1;
            float answer = 1 / (i * _exp) * z;
            float lasterror;
            float summ = answer;

            do
            {
                lasterror = answer;
                answer = 1 / (float)(Math.Pow(i, 2) * Math.Pow(_exp, degree)) * z;
                summ += answer;
                degree++;
            } while (Math.Abs(lasterror - answer) > 0.001);

            return summ;
        }
        public static double task2(int inputX)
        {
            double answer = 0, summ = 0;
            int numerator = 3, degree = 3, z = 1;

            answer = inputX - Math.Pow(inputX, degree) * z / factorial(numerator);
            summ += answer;
            degree = 5;
            numerator = 5;

            while (answer > 0.001)
            {
                answer = Math.Pow(inputX, degree) * z / factorial(numerator);
                summ += answer;
                degree += 2;
                numerator += 2;
                z = -1;
            }
            return summ;
        }

        public static int factorial(int n)
        {
            int _factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                _factorial *= i;
            }
            return _factorial;
        }

    }
}
