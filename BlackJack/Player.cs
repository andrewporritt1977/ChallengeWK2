using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player : Participant
    {
        public Player()
        {
            Hand = CardDeck.TakeCard() + CardDeck.TakeCard();
        }

        public bool Win { get; set; }
    }
}
