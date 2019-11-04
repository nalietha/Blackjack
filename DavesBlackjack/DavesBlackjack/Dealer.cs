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

        public string Choice()
        {
            _handValue = CalcuateCurrentHand();
            // check hand
            if (_handValue < 17)
            {
                Hit();
                return "Dealer Hits";
            }
            else
            { 
                return "Dealer Stays";
            }
        }

        public override bool Hit()
        {
            CardList.Add(GetNextCard());
            _handValue = CalcuateCurrentHand();
            return Busted(CalcuateCurrentHand());
        }

    }
}