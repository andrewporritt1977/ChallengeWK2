using System;
using TechTalk.SpecFlow;

namespace ChallengeWK2.Specs
{
    [Binding]
    public class ChhallengeWK2Steps
    {
        [Given(@"I have opened the the app")]
        public void GivenIHaveOpenedTheTheApp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to play a game")]
        public void GivenIWantToPlayAGame()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*)")]
        public void WhenIEnter(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"then game (.*) is loaded")]
        public void ThenThenGameIsLoaded(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"then a message saying ""(.*)"" is returned\.")]
        public void ThenThenAMessageSayingIsReturned_(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
