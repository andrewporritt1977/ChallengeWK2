using BlackJack;
using System;

namespace GameSelection
{
    public class GameSelectionFactory
    {
        public IGame SelectGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1:
                    //HighLow
                    break;
                case 2:
                    //NumberPoke
                    break;
                case 3:
                    return new BlackJackEngine();
                default:
                    break;
            }
            return null;
       
        }
    }
}
