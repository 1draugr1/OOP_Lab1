using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task1
{
    static class Algorithms
    {
        public static int CalculateGreatestCommonDivisor(int firstNum, int secondNum)
        {
            if (firstNum == 0)
                return secondNum;
            while (secondNum != 0)
            {
                int temp = secondNum;
                secondNum = firstNum % secondNum;
                firstNum = temp;
            }
            return firstNum;
        }

        public static int CalculateLeastCommonMultiple(int firstNum, int secondNum)
        {
            return Math.Abs(firstNum * secondNum) / CalculateGreatestCommonDivisor(firstNum, secondNum);
        }
    }
}
