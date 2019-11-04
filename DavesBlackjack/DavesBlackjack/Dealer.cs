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
            _handValue = CalcuateCurrentHand();
        }

        public bool Choice()
        {
            _handValue = CalcuateCurrentHand();
            // check hand
            if (_handValue < 17)
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
            _handValue = CalcuateCurrentHand();
            return Busted(CalcuateCurrentHand());
        }

    }
}