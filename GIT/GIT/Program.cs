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
            Console.WriteLine(task1());
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
    }
}
