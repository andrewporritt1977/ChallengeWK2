using System;
using System.Collections.Generic;

namespace NumberPoke
{
    public class NumberPoke
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int ThirdNumber { get; set; }

        public bool heldFirst { get; set; }

        public bool heldSecond { get; set; }

        public bool heldThird { get; set; }

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

        public void Deal()
        {
            Random r = new Random();

            if (!heldFirst) FirstNumber = r.Next(1, 10);
            if (!heldSecond) SecondNumber = r.Next(1, 10);
            if (!heldThird) ThirdNumber = r.Next(1, 10);
        }

        public void Hold(int hold)
        {
            switch (hold)
            {
                case 1:
                    heldFirst = true;
                    break;
                case 2:
                    heldSecond = true;
                    break;
                case 3:
                    heldThird = true;
                    break;
                default:
                    break;

            }
        }

    }
}
