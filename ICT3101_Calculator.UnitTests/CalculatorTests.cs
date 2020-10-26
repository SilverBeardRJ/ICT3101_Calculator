using NUnit.Framework;
using System;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(10)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(10, 10)]
        public void TriangleArea_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {

            Assert.That(() => _calculator.TriangleArea(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]
        [TestCase(10)]
        public void CircleArea_WithNegativeInputs_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.CircleArea(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithNegativeInputs_ResultEqualToSum(int a)
        {
            IFileReader fileReader = new FileReader();
            Assert.That(() => _calculator.GenMagicNum(a,fileReader), Is.EqualTo(46));
        }

    }
}