using System;
using TechTalk.SpecFlow;

namespace ChallengeWK2.Specs
{
    [Binding]
    public class ChhallengeWK2Steps
    {
        [Given(@"I have entered (.*) into the game selector")]
        public void GivenIHaveEnteredIntoTheGameSelector(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered null into the game selector")]
        public void GivenIHaveEnteredNullIntoTheGameSelector()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press select")]
        public void WhenIPressSelect()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be an error message telling the user that there is no associated game")]
        public void ThenTheResultShouldBeAnErrorMessageTellingTheUserThatThereIsNoAssociatedGame()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
