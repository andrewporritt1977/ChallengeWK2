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
            numberPoke.Deal();
        }

        [Then(@"my first number is valid")]
        public void ThenMyFirstNumberIsValid()
        {
            Assert.IsTrue(numberPoke.FirstNumber > 0);
            Assert.IsTrue(numberPoke.FirstNumber < 11);
        }

        [Then(@"my second number is valid")]
        public void ThenMySecondNumberIsValid()
        {
            Assert.IsTrue(numberPoke.SecondNumber > 0);
            Assert.IsTrue(numberPoke.SecondNumber < 11);
        }


        [Then(@"my third number is valid")]
        public void ThenMyThirdNumberIsValid()
        {
            Assert.IsTrue(numberPoke.ThirdNumber > 0);
            Assert.IsTrue(numberPoke.ThirdNumber < 11);
        }

        [When(@"I press hold on (.*)")]
        public void WhenIPressHoldOn(int hold)
        {
            numberPoke.Hold(hold);
        }

        [Then(@"only number (.*) is re-dealt")]
        public void ThenOnlyNumberIsRe_Dealt(int unheld)
        {
            numberPoke.Deal();
            // Assert only unheld is dealt
        }

        [Then(@"my first number is still (.*)")]
        public void ThenMyFirstNumberIsStill(int firstNumber)
        {
            Assert.AreEqual(numberPoke.FirstNumber, firstNumber);
        }


        [Then(@"my second number is still (.*)")]
        public void ThenMySecondNumberIsStill(int secondNumber)
        {
            Assert.AreEqual(numberPoke.SecondNumber, secondNumber);
        }

    }
}
