using System;

namespace NumberPoke
{
    public class NumberPoke
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int ThirdNumber { get; set; }

        public string GameResult()
        {
            if ((FirstNumber == SecondNumber) & (SecondNumber == ThirdNumber)) 
            {
                return "Superwin";
            } else if ((FirstNumber == SecondNumber) || (SecondNumber == ThirdNumber) || (FirstNumber == ThirdNumber))
            {
                return "Win";
            } else
            {
                return "Lose";
            }
  
        }

        public int Deal()
        {
            Random r = new Random();
            return r.Next(1, 10);
        }
   
    }
}
