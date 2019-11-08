﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Player 
    {
        public List<Card> CardList = new List<Card>();

        private decimal PlayerMoney = 1000.00m;
        private int _handValue = 0;
        public int handValue { get { return _handValue; } }

        public Player()
        {
            CalcuateCurrentHand();
        }

        /// <summary>
        /// Gets the value that the player currently has in their hand
        /// Called at the start of each round
        /// </summary>
        /// <returns>sum of the cards in hand</returns>
        public void CalcuateCurrentHand()
        {
            int sum = 0;
            int softAces = 0;

            foreach (var Card in CardList)
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
            _handValue = sum;
        }

        public bool CheckBusted()
        {
            CalcuateCurrentHand();
            if (_handValue > 21)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Hit Function for the players, also used by dealer
        /// </summary>
        public virtual bool Hit()
        {
            // Deck call for next card
            CardList.Add(Deck.GetNextCard());
            CalcuateCurrentHand();
            return CheckBusted();
        }
        /// <summary>
        /// Stay function, used by player and dealer
        /// </summary>
        public void Stay()
        {
            // Go to next player choice
            // not needed
         
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

        /// <summary>
        /// Clears CardList, and sets hands to zero
        /// </summary>
        public void ClearHand()
        {
            CardList.Clear();
            _handValue = 0;

            

        }

    }
}
