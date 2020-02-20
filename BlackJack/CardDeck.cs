using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public static class CardDeck
    {
        public static int TakeCard()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

    }
}
