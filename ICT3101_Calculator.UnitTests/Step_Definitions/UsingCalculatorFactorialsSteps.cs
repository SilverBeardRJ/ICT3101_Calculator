﻿using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialsSteps
    {
        public readonly Calculator _calculator;
        public UsingCalculatorFactorialsSteps(Calculator calculator)
        {
            this._calculator = calculator;
        }
        private double _result;
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0, int p1)
        {
            _result = _calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial error result should be ""(.*)""")]
        public void ThenTheFactorialErrorResultShouldBe(string p0)
        {
            //Assert.That(_result, Is.EqualTo(p0));
            Assert.That(() => _result, Throws.ArgumentException);
        }
    }
}
