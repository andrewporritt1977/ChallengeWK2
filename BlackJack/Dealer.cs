using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Dealer : Participant
    {
        public Dealer()
        {
            Hand = CardDeck.TakeCard();
            HiddenCard = CardDeck.TakeCard();
        }

        public int HiddenCard { get; set; } 
    }
}
