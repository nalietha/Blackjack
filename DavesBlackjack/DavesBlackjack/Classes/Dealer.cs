using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
   public class Dealer : Player
    {
        public Dealer()
        {
            CalcuateCurrentHand();
        }

        /// <summary>
        /// Dealer chooses to take a card based on hand value
        /// </summary>
        /// <returns>True if card taken, otherwise falss</returns>
        public bool Choice(Deck deck)
        {
            CalcuateCurrentHand();
            // check hand value
            if (handValue < 17)
            {
                Hit(deck);
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}