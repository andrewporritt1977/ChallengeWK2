using System;
using TechTalk.SpecFlow;
using BlackJack;

namespace ChallengeWK2.Specs
{
    [Binding]
    public class BlackJSteps
    {
        Dealer dealer = new Dealer();
        Human human = new Human();

        [Given(@"the dealer's stand attribute is (.*)")]
        public void GivenTheDealerSStandAttributeIsTrue(bool stand)
        {
            dealer.Stand = stand;
        }

        [Given(@"the human's hand is (.*)")]
        public void GivenTheHumanSHandIs(int hand)
        {
            human.Hand = hand;
        }

        [Given(@"the human's stand attribute is (.*)")]
        public void GivenTheHumanSStandAttributeIsTrue(bool stand)
        {
            human.Stand = stand;
        }

        [When(@"the dealer's hand is (.*)")]
        public void WhenTheDealerSHandIs(int hand)
        {
            dealer.Hand = hand;
        }

        [When(@"the human's hand is (.*)")]
        public void WhenTheHumanSHandIs(int hand)
        {
            human.Hand = hand;
        }

        [Then(@"the result for the human is (.*)")]
        public void ThenTheResultForTheHumanIsLose(bool result)
        {
            human.Win = result;
        }

        [Then(@"the result for human is (.*)")]
        public void ThenTheResultForHumanIsWin(bool result)
        {
            human.Win = result;
        }

        [Then(@"the dealer's hand is (.*)")]
        public void ThenTheDealerSHandIs(int hand)
        {
            dealer.Hand = hand;
        }

        [Then(@"dealer's stand attribute is (.*)")]
        public void ThenDealerSStandAttributeIsTrue(bool stand)
        {
            dealer.Stand = stand;
        }

        [Then(@"the dealer must take a card")]
        public void ThenTheDealerMustTakeACard()
        {
            dealer.TakeCard();
        }
    }
}
