using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task1
{
    public class RationalNumber
    {
        private int numerator { get; }
        private int denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Знаменатель не может быть равен нулю.");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            int gcd = Algorithms.CalculateGreatestCommonDivisor(Math.Abs(numerator), Math.Abs(denominator));
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();
            else
                return numerator.ToString() + '/' + denominator.ToString();
        }

        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            int newNumerator = num1.numerator * (newDenominator / num1.denominator) + num2.numerator * (newDenominator / num2.denominator);
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }

        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            int newNumerator = num1.numerator * (newDenominator / num1.denominator) - num2.numerator * (newDenominator / num2.denominator);
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }

        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = num1.denominator * num2.denominator;
            int newNumerator = num1.numerator * num2.numerator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }

        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = num1.denominator * num2.numerator;
            int newNumerator = num1.numerator * num2.denominator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is RationalNumber))
                return false;

            RationalNumber other = (RationalNumber)obj;
            return this.numerator == other.numerator && this.denominator == other.denominator;
        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }

        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            return num1.Equals(num2);
        }

        public static bool operator !=(RationalNumber num1, RationalNumber num2)
        {
            return !num1.Equals(num2);
        }

        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            if (num1.numerator * (newDenominator / num1.denominator) < num2.numerator * (newDenominator / num2.denominator))
                return true;
            else
                return false;
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            if (num1.numerator * (newDenominator / num1.denominator) > num2.numerator * (newDenominator / num2.denominator))
                return true;
            else
                return false;
        }

        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            if (num1.numerator * (newDenominator / num1.denominator) <= num2.numerator * (newDenominator / num2.denominator))
                return true;
            else
                return false;
        }

        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            int newDenominator = Algorithms.CalculateLeastCommonMultiple(num1.denominator, num2.denominator);
            if (num1.numerator * (newDenominator / num1.denominator) >= num2.numerator * (newDenominator / num2.denominator))
                return true;
            else
                return false;
        }

        public static RationalNumber operator -(RationalNumber num1)
        {
            RationalNumber result = new RationalNumber(-num1.numerator, num1.denominator);
            return result;
        }
    }
}
