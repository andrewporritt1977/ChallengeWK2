//using System;
//using TechTalk.SpecFlow;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace ChallengeWK2.Specs
//{
//    [Binding]
//    public class GameSelectionSteps
//    {
//        private string game;

//        private GameSelection.GameSelectionFactory gameSelection = new GameSelection.GameSelectionFactory();

//        [Given(@"I have entered (.*) into the game selector")]
//        public void GivenIHaveEnteredIntoTheGameSelector(int numSelect)
//        {
//            gameSelection.Selector = numSelect;
//        }
        
//        [When(@"I press select")]
//        public void WhenIPressSelect()
//        {
//            game = gameSelection.Select();
//        }
        
//        [Then(@"the result should be (.*) on the screen")]
//        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
//        {
//            Assert.AreEqual(expectedResult, game);
//        }

//        [Then(@"the result should be (.*)")]
//        public void ThenTheResultShouldBeError(string expectedResult)
//        {
//            Assert.AreEqual(expectedResult, game);
//        }

//    }
//}
