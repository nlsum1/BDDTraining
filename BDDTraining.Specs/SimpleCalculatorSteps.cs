using System;
using BDDTraining;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDTraining.Specs
{
    [Binding]
    public class SimpleCalculatorSteps
    {
        private int result;
        private SimpleCalculator simplecalculator = new SimpleCalculator();
       

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            simplecalculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            simplecalculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = simplecalculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            result = simplecalculator.Subtract();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = simplecalculator.Divide();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = simplecalculator.Multiply();
        }

        [When(@"I press clear")]
        public void WhenIPressClear()
        {
            result = simplecalculator.Clear();
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
