using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithNegativeInputs_ResultEqualToSum(int a)
        {
            Assert.That(() => _calculator.GenMagicNum(a, _mockFileReader), Is.EqualTo(46));
        }
    }
}
