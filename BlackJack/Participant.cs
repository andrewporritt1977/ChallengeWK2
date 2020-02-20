using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Participant
    {
        public int Hand { get; set; }
        public bool Stand { get; set; }

        public string TakeCard()
        {
            Hand = Hand + CardDeck.TakeCard();

            if (Hand == 21)
            {
                return "blackjack";
            }
            if (Hand > 21)
            {
                return "bust";
            }
            return "ok";

        }
    }
}
