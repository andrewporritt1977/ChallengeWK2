﻿using System;
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

    }
}
