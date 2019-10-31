using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Dealer : Player
    {

        private List<Card> _dealersCardList = new List<Card>();
        private int currentHand = 0;

        private int _dealerHandValue = 0;

        public Dealer(/*List<DealerDeck> currCard*/)
        {
            //_dealersCardList.Add(currCard);
        }

        private void Choice()
        {
            currentHand = CalcuateCurrentHand();
            // check hand
            if (currentHand < 17)
                Hit();
            else
                Stay();
        }

        public override void Hit()
        {
            _dealersCardList.Add(GetNextCard());
        }

    }
}