using System;

namespace GameSelection
{
    public class GameSelection
    {
        public int Selector { get; set; }

        public string Select()
        {
            if (Selector >0 && Selector <4)
            {
                return "Game" + Selector;
            } else
            {
                return "Error";
            }
            
        }
    }
}
