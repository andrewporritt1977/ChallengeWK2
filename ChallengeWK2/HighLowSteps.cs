using System;
using TechTalk.SpecFlow;
using HighLow;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ChallengeWK2.Specs
{
    [Binding]
    public class HighLowSteps
    {
        private string result;
        private HighLow.HighLow highLow = new HighLow.HighLow();

        [Given(@"I have a target number (.*)")]
        public void GivenIHaveATargetNumber(int target)
        {
            highLow.Target = target;
        }

        [When(@"I guess (.*)")]
        public void WhenIGuess(int guess)
        {
            highLow.Guess = guess;
        }

        [Then(@"the highLow result will be (.*)")]
        public void ThenTheHighLowResultWillBeLose(string expectedHighLowResult)
        {
                        result = highLow.Result();
            Assert.AreEqual(expectedHighLowResult, result);
        }


    }


}
