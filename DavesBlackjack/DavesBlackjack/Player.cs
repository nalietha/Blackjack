using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Player 
    {
        private List<Card> _playersCardList = new List<Card>();
        private Deck deck;

        private decimal PlayerMoney = 1000.00m;
        private int _playerValue = 0;

        /// <summary>
        /// Returns the number of cards in the players hand
        /// </summary>
        public int NumOfCards { get { return _playersCardList.Count(); } }

        public Player(Deck deck)
        {
            this.deck = deck;
            _playerValue = CalcuateCurrentHand();
        }

        /// <summary>
        /// Resets the cards in the players hand
        /// </summary>
        public virtual void ResetCards()
        {
            _playersCardList.Clear();
        }

        /// <summary>
        /// Returns the card in the players hand at the given index
        /// </summary>
        /// <param name="index">Index of the card</param>
        /// <returns></returns>
        public virtual Card GetCard(int index)
        {
            return _playersCardList[index];
        }

        /// <summary>
        /// Gets the value that the player currently has in their hand
        /// Called at the start of each round
        /// </summary>
        /// <returns>sum of the cards in hand</returns>
        public int CalcuateCurrentHand()
        {
            int sum = 0;
            int softAces = 0;

            foreach (var Card in _playersCardList)
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

        public bool Busted()
        {
            if (CalcuateCurrentHand() > 21)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Hit Function for the players, also used by dealer
        /// </summary>
        public virtual void Hit()
        {
            // Deck call for next card
            _playersCardList.Add(deck.GetNextCard());
            
        }
        /// <summary>
        /// Stay function, used by player and dealer
        /// </summary>
        public void Stay()
        {
            // Go to next player choice
            // NextTurn();
         
        }
        /// <summary>
        /// Bet function for the player to increase his bet.
        /// </summary>
        /// <param name="amount">amount the player is betting.</param>
        public void Bet(decimal amount)
        {
            
            if(PlayerMoney-amount < 0)
            {
                // Insignifant Money
                // Display and cancel bet
            }
            else
            {
                // Place Bet

            }

        }

    }
}
