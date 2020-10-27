using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Tasks
    {
        public static float task1(float angleX)
        {
            angleX = angleX * (float)Math.PI / 180;

            int z = -1;
            float currentNumber = (float)(Math.Pow(Math.Sin(angleX), 1) / 1) * z;
            float LastNumber = 0;
            int i = 1;
            do
            {
                i++;
                LastNumber = (float)(Math.Pow(Math.Sin(angleX), i + 2) / i) * z;
                currentNumber = LastNumber;
            } while (Math.Abs(LastNumber - currentNumber) > 0.001);

            return LastNumber;
        }
    }
}
