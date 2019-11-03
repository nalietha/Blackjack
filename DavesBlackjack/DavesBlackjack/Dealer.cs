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
        private Deck deck;
        private int _dealerHandValue = 0;

        /// <summary>
        /// Retruns the number of cards the dealer has
        /// </summary>
        public new int NumOfCards { get { return _dealersCardList.Count(); } }


        public Dealer(Deck deck) : base(deck)
        {
            this.deck = deck;
            //_dealersCardList.Add(currCard);
        }

        /// <summary>
        /// Resets the Cards in the Dealers Hand
        /// </summary>
        public override void ResetCards()
        {
            _dealersCardList.Clear();
        }

        public bool Choice()
        {
            currentHand = CalcuateCurrentHand();
            // check hand
            if (currentHand < 17)
            {
                Hit();
                return false;//can continue
            }
            else
            {
                Stay();
                return true;//cannot continue
            }
        }

        public bool Busted()
        {
            if (CalcuateCurrentHand() > 21)
                return true;
            else
                return false;
        }

        public new int CalcuateCurrentHand()
        {
            int sum = 0;
            int softAces = 0;

            foreach (var Card in _dealersCardList)
            {
                if (Card.Value == 1)
                {
                    sum += 11;
                    softAces++;
                }
                else
                {
                    sum += Card.Value;
                }
                while (sum > 21 && softAces > 0)
                {
                    softAces--;
                    sum -= 10;
                }
            }
            return sum;
        }

        public override void Hit()
        {
            _dealersCardList.Add(deck.GetNextCard());
        }

        /// <summary>
        /// Function to get the Cards inorder for the UI to get the image file names.
        /// </summary>
        /// <param name="index">Index of the Card</param>
        /// <returns></returns>
        public override Card GetCard(int index)
        {
            return _dealersCardList[index];
        }
    }
}