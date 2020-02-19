using System;
using TechTalk.SpecFlow;
using NumberPoke;  
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeWK2.Specs
{
    [Binding]
    public class NumberPokeSteps
    {
        private string gameResult;
        private int cardOne;
        private int cardTwo;
        private int cardThree;
        
        private NumberPoke.NumberPoke numberPoke = new NumberPoke.NumberPoke();

        [Given(@"my first number is (.*)")]
        public void GivenMyFirstNumberIs(int num1)
        {
            numberPoke.FirstNumber = num1;
        }

        [Given(@"my second number is (.*)")]
        public void GivenMySecondNumberIs(int num2)
        {
            numberPoke.SecondNumber = num2;
        }

        [Given(@"and my third number is (.*)")]
        public void GivenAndMyThirdNumberIs(int num3)
        {
            numberPoke.ThirdNumber = num3;
        }

        [When(@"I press continue")]
        public void WhenIPressContinue()
        {
            gameResult = numberPoke.GameResult();
        }

        [Then(@"the result will be (.*)")]
        public void ThenTheResultWillBeWin(string expectedResult)
        {
            Assert.AreEqual(gameResult, expectedResult);
        }

        [Given(@"I press Start")]
        public void GivenIPressStart()
        {
            cardOne = numberPoke.Deal();
            cardTwo = numberPoke.Deal();
            cardThree = numberPoke.Deal();
        }

        [Then(@"my first number is valid")]
        public void ThenMyFirstNumberIsValid()
        {
            Assert.IsTrue(cardOne > 0);
            Assert.IsTrue(cardOne < 11);
        }

        [Then(@"my second number is valid")]
        public void ThenMySecondNumberIsValid()
        {
            Assert.IsTrue(cardTwo > 0);
            Assert.IsTrue(cardTwo < 11);
        }


        [Then(@"my third number is valid")]
        public void ThenMyThirdNumberIsValid()
        {
            Assert.IsTrue(cardThree > 0);
            Assert.IsTrue(cardThree < 11);
        }
    }
}
