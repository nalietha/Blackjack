using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Dealer : Player
    {

        public Dealer()
        {
            CalcuateCurrentHand();
        }

        public bool Choice()
        {
            CalcuateCurrentHand();
            // check hand value
            if (handValue < 17)
            {
                Hit();
                return true;
            }
            else
            { 
                return false;
            }
        }

        public override bool Hit()
        {
            CardList.Add(Deck.GetNextCard());
            CalcuateCurrentHand();
            return CheckBusted();
        }

    }
}