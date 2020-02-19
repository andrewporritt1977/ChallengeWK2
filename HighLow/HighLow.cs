using System;

namespace HighLow
{
    public class HighLow
    {
        public int Target { get; set; }
        public int RoundNumber { get; set; }
        public int Guess { get; set; }

        public string Result()
        {
            if (Guess == Target) {
                return "Win";
            } else
            {
                return "Lose";
            }
        }
    }
}
