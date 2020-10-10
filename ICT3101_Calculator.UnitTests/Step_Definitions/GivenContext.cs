using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    
    [Binding]
    public class GivenContext
    {
        public readonly Calculator _calculator;
        public GivenContext(Calculator calculator)
        {
            this._calculator = calculator;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
    }
}
