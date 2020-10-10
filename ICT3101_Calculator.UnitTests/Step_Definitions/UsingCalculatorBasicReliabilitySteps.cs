using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        public readonly Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calculator)
        {
            this._calculator = calculator;
        }
        private double _result;
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Failure Intenstiy")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFailureIntenstiy(int p0, int p1)
        {
            _result = _calculator.FailureIntensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press AEF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAEF(int p0, int p1)
        {
            _result = _calculator.AverageFailure(p0, p1);
        }
        
        [Then(@"the Failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the average number of expected failures result should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
