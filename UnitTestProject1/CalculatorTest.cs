using System;
using NUnit.Framework;
using CSharpCalculator;
using NUnit.Framework.Constraints;

namespace UnitTestProject1
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator Calc;

        [SetUp]
        public void Setup()
        {
            Calc = new Calculator();
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(-1, 1, 0)]
        [TestCase(2, 3, 5)]
        [TestCase("2", "3", 5)]
        public void ShouldReturnSum(object a, object b, double expected)
        {
            Assert.AreEqual(expected, Calc.Add(a, b));
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(1, 2, -1)]
        [TestCase(-1, 1, -2)]
        [TestCase(2, 3, -1)]
        public void ShouldReturnSub(object a, object b, object expected)
        {
            Assert.AreEqual(expected, Calc.Sub(a, b));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 0.5)]
        [TestCase(-1, 1, -1)]
        public void ShouldReturnDivideResult(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calc.Divide(a, b));
        }

        [Test]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(-5, ExpectedResult = 5)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-5.0236, ExpectedResult = 5.0236)]
        public object ShouldReturnAbs(object x)
        {
            return Calc.Abs(x);
        }

        [Test]
        [TestCase(90, ExpectedResult = 0)]
        [TestCase(-90, ExpectedResult = 0)]
        [TestCase(-120, ExpectedResult = -0.5)]
        [TestCase(Math.PI/2, ExpectedResult = 0)]
        [TestCase(Math.PI, ExpectedResult = -1)]
        [TestCase(0, ExpectedResult = 1)]
        public object ShouldReturnCos(object x)
        {
            return Calc.Cos(x);
        }

        [Test]
        [TestCase(Math.PI/2, ExpectedResult = 1)]
        [TestCase(3*Math.PI/2, ExpectedResult = -1)]
        [TestCase(Math.PI/6, ExpectedResult = 0.5)]
        [TestCase(Math.PI, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        public object ShouldReturnSin(object x)
        {
            return Calc.Sin(x);
        }

        [Test]
        [TestCase(-1, ExpectedResult = true)]
        [TestCase(-1.000055698, ExpectedResult = true)]
        [TestCase(-0.00000000000000000001, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(1.36598779, ExpectedResult = false)]
        public bool ShouldReturnIfValueIsNegative(object x)
        {
            return Calc.isNegative(x);
        }

        [Test]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(-1.000055698, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(1.36598779, ExpectedResult = true)]
        public bool ShouldReturnIfValueIsPositive(object x)
        {
            return Calc.isPositive(x);
        }

        [Test]
        [TestCase(10, 15, ExpectedResult = 150)]
        [TestCase(-1, 15, ExpectedResult = -15)]
        [TestCase(0.0005554, 15, ExpectedResult = 0.008331)]
        [TestCase(0, 15, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public double ShouldResutnMultiplication(double a, double b)
        {
            return Calc.Multiply(a, b);
        }

        [Test]
        [TestCase(10, 15, ExpectedResult = 1000000000000000)]
        [TestCase(-1, 14, ExpectedResult = 1)]
        [TestCase(0, 15, ExpectedResult = 0)]
        [TestCase(2, 2, ExpectedResult = 4)]
        public double ShouldReturnPow(object a, object b)
        {
            return Calc.Pow(a, b);
        }

        [Test]
        [TestCase(4, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = -2)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-1, ExpectedResult = Double.NaN)]
        public double ShouldReturnSqrt(object x)
        {
            return Calc.Sqrt(x);
        }

    }
}
