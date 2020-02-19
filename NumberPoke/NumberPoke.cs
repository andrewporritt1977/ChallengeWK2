using System;
using System.Collections.Generic;

namespace NumberPoke
{
    public class NumberPoke
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int ThirdNumber { get; set; }

        private bool HeldFirst { get; set; }

        private bool HeldSecond { get; set; }

        private bool HeldThird { get; set; }

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

            if (!HeldFirst) FirstNumber = r.Next(1, 10);
            if (!HeldSecond) SecondNumber = r.Next(1, 10);
            if (!HeldThird) ThirdNumber = r.Next(1, 10);
        }

        public void Hold(int hold)
        {
            switch (hold)
            {
                case 1:
                    HeldFirst = true;
                    break;
                case 2:
                    HeldSecond = true;
                    break;
                case 3:
                    HeldThird = true;
                    break;
                default:
                    break;

            }
        }

    }
}
