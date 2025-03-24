using System;
using Lab1.Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests
{
    [TestClass]
    public class OverrideComparisonOperationsUnitTests
    {
        [DataTestMethod]
        [DataRow(3, 6, 3, 6, true)]
        [DataRow(3, 6, 12, 24, true)]
        [DataRow(3, 6, 12, 8, false)]
        [DataRow(-3, 6, -3, 6, true)]
        [DataRow(-3, 6, -12, 24, true)]
        [DataRow(-3, 6, -12, 8, false)]
        [DataRow(-3, 6, 3, 6, false)]
        [DataRow(-3, 6, 12, 24, false)]
        [DataRow(-3, 6, 12, 8, false)]
        [DataRow(3, 6, -3, 6, false)]
        [DataRow(3, 6, -12, 24, false)]
        [DataRow(3, 6, -12, 8, false)]
        [DataRow(2, 7, 2, 7, true)]
        [DataRow(2, 7, 3, 5, false)]
        [DataRow(-2, 7, -2, 7, true)]
        [DataRow(-2, 7, -3, 5, false)]
        [DataRow(-2, 7, 2, 7, false)]
        [DataRow(-2, 7, 3, 5, false)]
        [DataRow(2, 7, -2, 7, false)]
        [DataRow(2, 7, -3, 5, false)]
        [DataRow(2, 7, 8, 28, true)]
        [DataRow(2, 7, 3, 6, false)]
        [DataRow(-2, 7, 8, 28, false)]
        [DataRow(-2, 7, 3, 6, false)]
        [DataRow(2, 7, -8, 28, false)]
        [DataRow(2, 7, -3, 6, false)]
        [DataRow(-2, 7, -8, 28, true)]
        [DataRow(-2, 7, -3, 6, false)]
        [DataRow(3, 6, 0, 3, false)]
        [DataRow(-3, 6, 0, 3, false)]
        [DataRow(-3, 6, 0, -3, false)]
        [DataRow(2, 7, 0, 3, false)]
        [DataRow(-2, 7, 0, 3, false)]
        [DataRow(-2, 7, 0, -3, false)]
        [DataRow(0, 7, 0, 3, true)]
        [DataRow(0, -7, 0, 3, true)]
        [DataRow(0, 7, 0, -3, true)]

        public void OverrideEqualAndNotEqualOperationsUnitTest(int numerator1, int denominator1, int numerator2, int denominator2, bool expected)
        {
            RationalNumber rational1 = new RationalNumber(numerator1, denominator1);
            RationalNumber rational2 = new RationalNumber(numerator2, denominator2);

            RationalNumber rational3 = new RationalNumber(-numerator1, -denominator1);
            RationalNumber rational4 = new RationalNumber(-numerator2, -denominator2);

            Assert.AreEqual(rational1 == rational2, expected);
            Assert.AreEqual(rational2 == rational1, expected);
            Assert.AreEqual(rational3 == rational4, expected);
            Assert.AreEqual(rational4 == rational3, expected);

            Assert.AreEqual(rational1 != rational2, !expected);
            Assert.AreEqual(rational2 != rational1, !expected);
            Assert.AreEqual(rational3 != rational4, !expected);
            Assert.AreEqual(rational4 != rational3, !expected);
        }

        [DataTestMethod]
        [DataRow(3, 6, 3, 6, false)]
        [DataRow(3, 6, 12, 24, false)]
        [DataRow(3, 6, 12, 8, false)]
        [DataRow(-3, 6, -3, 6, false)]
        [DataRow(-3, 6, -12, 24, false)]
        [DataRow(-3, 6, -12, 8, true)]
        [DataRow(-3, 6, 3, 6, false)]
        [DataRow(-3, 6, 12, 24, false)]
        [DataRow(-3, 6, 12, 8, false)]
        [DataRow(3, 6, -3, 6, true)]
        [DataRow(3, 6, -12, 24, true)]
        [DataRow(3, 6, -12, 8, true)]
        [DataRow(2, 7, 2, 7, false)]
        [DataRow(2, 7, 3, 5, false)]
        [DataRow(-2, 7, -2, 7, false)]
        [DataRow(-2, 7, -3, 5, true)]
        [DataRow(-2, 7, 2, 7, false)]
        [DataRow(-2, 7, 3, 5, false)]
        [DataRow(2, 7, -2, 7, true)]
        [DataRow(2, 7, -3, 5, true)]
        [DataRow(2, 7, 8, 28, false)]
        [DataRow(2, 7, 3, 6, false)]
        [DataRow(-2, 7, 8, 28, false)]
        [DataRow(-2, 7, 3, 6, false)]
        [DataRow(2, 7, -8, 28, true)]
        [DataRow(2, 7, -3, 6, true)]
        [DataRow(-2, 7, -8, 28, false)]
        [DataRow(-2, 7, -3, 6, true)]
        [DataRow(3, 6, 0, 3, true)]
        [DataRow(-3, 6, 0, 3, false)]
        [DataRow(-3, 6, 0, -3, false)]
        [DataRow(2, 7, 0, 3, true)]
        [DataRow(-2, 7, 0, 3, false)]
        [DataRow(-2, 7, 0, -3, false)]
        [DataRow(0, 7, 0, 3, false)]
        [DataRow(0, -7, 0, 3, false)]
        [DataRow(0, 7, 0, -3, false)]
        public void OverrideMoreAndLessOperationsUnitTest(int numerator1, int denominator1, int numerator2, int denominator2, bool expected)
        {
            RationalNumber rational1 = new RationalNumber(numerator1, denominator1);
            RationalNumber rational2 = new RationalNumber(numerator2, denominator2);

            RationalNumber rational3 = new RationalNumber(-numerator1, -denominator1);
            RationalNumber rational4 = new RationalNumber(-numerator2, -denominator2);

            Assert.AreEqual(rational1 > rational2, expected);
            Assert.AreEqual(rational2 < rational1, expected);
            Assert.AreEqual(rational3 > rational4, expected);
            Assert.AreEqual(rational4 < rational3, expected);
        }
    }

    [TestClass]
    public class OverrideAriphmeticOperationsUnitTests
    {
        [DataTestMethod]
        [DataRow(3, 6, 12, 8, "2")]
        [DataRow(3, 6, 2, 8, "3/4")]
        [DataRow(3, 6, 8, 6, "11/6")]
        [DataRow(5, 75, 164, 15, "11")]
        [DataRow(7, 5, 3, 4, "43/20")]
        [DataRow(3, 5, 8, 5, "11/5")]
        [DataRow(0, 5, 0, 9, "0")]
        [DataRow(-3, 6, -12, 8, "-2")]
        [DataRow(-3, 6, -2, 8, "-3/4")]
        [DataRow(-3, 6, -8, 6, "-11/6")]
        [DataRow(-5, 75, -164, 15, "-11")]
        [DataRow(-7, 5, -3, 4, "-43/20")]
        [DataRow(-3, 5, -8, 5, "-11/5")]
        [DataRow(0, -5, 0, -9, "0")]
        [DataRow(3, 6, 9, 2, "5")]
        [DataRow(3, 6, 5, 7, "17/14")]
        [DataRow(3, 6, 5, 6, "4/3")]
        [DataRow(-3, 6, -9, 2, "-5")]
        [DataRow(-3, 6, -5, 7, "-17/14")]
        [DataRow(-3, 6, -5, 6, "-4/3")]
        [DataRow(3, 6, -11, 2, "-5")]
        [DataRow(3, 6, -12, 7, "-17/14")]
        [DataRow(3, 6, -11, 6, "-4/3")]
        [DataRow(-3, 6, 11, 2, "5")]
        [DataRow(-3, 6, 12, 7, "17/14")]
        [DataRow(-3, 6, 11, 6, "4/3")]
        [DataRow(12, 6, 0, 2, "2")]
        [DataRow(3, 6, 0, 2, "1/2")]
        [DataRow(3, 6, 0, 6, "1/2")]
        [DataRow(-12, 6, 0, 2, "-2")]
        [DataRow(-3, 6, 0, 2, "-1/2")]
        [DataRow(-3, 6, 0, 6, "-1/2")]
        [DataRow(5, 6, 0, 2, "5/6")]
        [DataRow(5, 6, 0, 6, "5/6")]
        [DataRow(-5, 6, 0, 2, "-5/6")]
        [DataRow(-5, 6, 0, 6, "-5/6")]
        public void RationalNumberOverrideSumTest(int num1, int den1, int num2, int den2, string expected)
        {
            RationalNumber rational1 = new RationalNumber(num1, den1);
            RationalNumber rational2 = new RationalNumber(num2, den2);
            RationalNumber actual1 = rational1 + rational2;
            RationalNumber actual2 = rational2 + rational1;

            RationalNumber rational3 = new RationalNumber(-num1, -den1);
            RationalNumber rational4 = new RationalNumber(-num2, -den2);
            RationalNumber actual3 = rational3 + rational4;
            RationalNumber actual4 = rational4 + rational3;

            Assert.AreEqual(expected, actual1.ToString());
            Assert.AreEqual(expected, actual2.ToString());
            Assert.AreEqual(expected, actual3.ToString());
            Assert.AreEqual(expected, actual4.ToString());
        }

        [DataTestMethod]
        [DataRow(3, 6, 12, 6, "1")]
        [DataRow(3, 6, 2, 8, "1/8")]
        [DataRow(5, 75, 75, 5, "1")]
        [DataRow(7, 5, 3, 4, "21/20")]
        [DataRow(0, 5, 0, 9, "0")]
        [DataRow(-3, 6, -12, 6, "1")]
        [DataRow(-3, 6, -2, 8, "1/8")]
        [DataRow(-5, 75, -75, 5, "1")]
        [DataRow(-7, 5, -3, 4, "21/20")]
        [DataRow(10, 2, 1, 1, "5")]
        [DataRow(3, 6, 5, 7, "5/14")]
        [DataRow(-10, 2, -1, 1, "5")]
        [DataRow(-3, 6, -5, 7, "5/14")]
        [DataRow(10, 2, -1, 1, "-5")]
        [DataRow(3, 6, -5, 7, "-5/14")]
        [DataRow(-10, 2, 1, 1, "-5")]
        [DataRow(-3, 6, 5, 7, "-5/14")]
        [DataRow(3, 6, 0, 2, "0")]
        [DataRow(-3, 6, 0, 2, "0")]
        [DataRow(5, 6, 0, 2, "0")]
        [DataRow(-5, 6, 0, 2, "0")]
        public void RationalNumberOverrideMulTest(int num1, int den1, int num2, int den2, string expected)
        {
            RationalNumber rational1 = new RationalNumber(num1, den1);
            RationalNumber rational2 = new RationalNumber(num2, den2);
            RationalNumber actual1 = rational1 * rational2;
            RationalNumber actual2 = rational2 * rational1;

            RationalNumber rational3 = new RationalNumber(-num1, -den1);
            RationalNumber rational4 = new RationalNumber(-num2, -den2);
            RationalNumber actual3 = rational3 * rational4;
            RationalNumber actual4 = rational4 * rational3;

            Assert.AreEqual(expected, actual1.ToString());
            Assert.AreEqual(expected, actual2.ToString());
            Assert.AreEqual(expected, actual3.ToString());
            Assert.AreEqual(expected, actual4.ToString());
        }

        [DataTestMethod]
        [DataRow(3, 6, 12, 8, "-1")]
        [DataRow(3, 6, 2, 8, "1/4")]
        [DataRow(3, 6, 8, 6, "-5/6")]
        [DataRow(5, 75, 164, 15, "-163/15")]
        [DataRow(7, 5, 3, 4, "13/20")]
        [DataRow(3, 5, 7, 5, "-4/5")]
        [DataRow(0, 5, 0, 9, "0")]
        [DataRow(-3, 6, -12, 8, "1")]
        [DataRow(-3, 6, -2, 8, "-1/4")]
        [DataRow(-3, 6, -8, 6, "5/6")]
        [DataRow(-5, 75, -164, 15, "163/15")]
        [DataRow(-7, 5, -3, 4, "-13/20")]
        [DataRow(-3, 5, 9, 5, "-12/5")]
        [DataRow(3, 6, 9, 2, "-4")]
        [DataRow(3, 6, 5, 7, "-3/14")]
        [DataRow(3, 6, 5, 6, "-1/3")]
        [DataRow(-3, 6, -9, 2, "4")]
        [DataRow(-3, 6, -5, 7, "3/14")]
        [DataRow(-3, 6, -5, 6, "1/3")]
        [DataRow(3, 6, -11, 2, "6")]
        [DataRow(3, 6, -12, 7, "31/14")]
        [DataRow(3, 6, -11, 6, "7/3")]
        [DataRow(-3, 6, 11, 2, "-6")]
        [DataRow(-3, 6, 12, 7, "-31/14")]
        [DataRow(-3, 6, 11, 6, "-7/3")]
        [DataRow(12, 6, 0, 2, "2")]
        [DataRow(3, 6, 0, 2, "1/2")]
        [DataRow(3, 6, 0, 6, "1/2")]
        [DataRow(-12, 6, 0, 2, "-2")]
        [DataRow(-3, 6, 0, 2, "-1/2")]
        [DataRow(-3, 6, 0, 6, "-1/2")]
        [DataRow(5, 6, 0, 2, "5/6")]
        [DataRow(5, 6, 0, 6, "5/6")]
        [DataRow(-5, 6, 0, 2, "-5/6")]
        [DataRow(-5, 6, 0, 6, "-5/6")]
        public void RationalNumberOverrideSubTest(int num1, int den1, int num2, int den2, string expected)
        {
            RationalNumber rational1 = new RationalNumber(num1, den1);
            RationalNumber rational2 = new RationalNumber(num2, den2);
            RationalNumber actual1 = rational1 - rational2;

            RationalNumber rational3 = new RationalNumber(-num1, -den1);
            RationalNumber rational4 = new RationalNumber(-num2, -den2);
            RationalNumber actual2 = rational3 - rational4;

            Assert.AreEqual(expected, actual1.ToString());
            Assert.AreEqual(expected, actual2.ToString());
        }


        [DataTestMethod]
        [DataRow(3, 6, 6, 12, "1")]
        [DataRow(3, 6, 8, 2, "1/8")]

        [DataRow(5, 75, 5, 75, "1")]
        [DataRow(7, 5, 4, 3, "21/20")]

        [DataRow(-3, 6, -6, 12, "1")]
        [DataRow(-3, 6, -8, 2, "1/8")]

        [DataRow(-5, 75, -5, 75, "1")]
        [DataRow(-7, 5, -4, 3, "21/20")]

        [DataRow(10, 2, 1, 1, "5")]
        [DataRow(3, 6, 7, 5, "5/14")]

        [DataRow(-10, 2, -1, 1, "5")]
        [DataRow(-3, 6, -7, 5, "5/14")]

        [DataRow(10, 2, -1, 1, "-5")]
        [DataRow(3, 6, -7, 5, "-5/14")]

        [DataRow(-10, 2, 1, 1, "-5")]
        [DataRow(-3, 6, 7, 5, "-5/14")]

        public void RationalNumberOverrideDivTest(int num1, int den1, int num2, int den2, string expected)
        {
            RationalNumber rational1 = new RationalNumber(num1, den1);
            RationalNumber rational2 = new RationalNumber(num2, den2);
            RationalNumber actual1 = rational1 / rational2;

            RationalNumber rational3 = new RationalNumber(-num1, -den1);
            RationalNumber rational4 = new RationalNumber(-num2, -den2);
            RationalNumber actual2 = rational3 / rational4;

            Assert.AreEqual(expected, actual1.ToString());
            Assert.AreEqual(expected, actual2.ToString());
        }

        [DataTestMethod]
        [DataRow(5, 7, "-5/7")]
        [DataRow(5, 10, "-1/2")]
        [DataRow(21, 14, "-3/2")]
        [DataRow(10, 10, "-1")]
        [DataRow(10, 5, "-2")]
        [DataRow(0, 10, "0")]
        [DataRow(-5, 7, "5/7")]
        [DataRow(-5, 10, "1/2")]
        [DataRow(-21, 14, "3/2")]
        [DataRow(-10, 10, "1")]
        [DataRow(-10, 5, "2")]

        public void RationalNumberOverrideUnaryMinusTest(int numerator, int denominator, string expected)
        {
            RationalNumber rational = new RationalNumber(numerator, denominator);
            RationalNumber actual = -rational;
            Assert.AreEqual(expected, actual.ToString());
        }
    }

    [TestClass]
    public class ToStringUnitTest
    {
        [DataTestMethod]
        [DataRow(5, 7, "5/7")]
        [DataRow(5, 10, "1/2")]
        [DataRow(21, 14, "3/2")]
        [DataRow(10, 10, "1")]
        [DataRow(10, 5, "2")]
        [DataRow(0, 10, "0")]
        [DataRow(-5, 7, "-5/7")]
        [DataRow(-5, 10, "-1/2")]
        [DataRow(-21, 14, "-3/2")]
        [DataRow(-10, 10, "-1")]
        [DataRow(-10, 5, "-2")]

        public void RationalNumberOverrideToStringTest(int numerator, int denominator, string expected)
        {
            RationalNumber rational1 = new RationalNumber(numerator, denominator);
            RationalNumber rational2 = new RationalNumber(-numerator, -denominator);
            string actual1 = rational1.ToString();
            string actual2 = rational2.ToString();
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }
    }
}
