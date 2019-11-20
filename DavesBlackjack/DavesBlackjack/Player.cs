using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavesBlackjack
{

    public class Player 
    {
        /// <summary>
        /// A list of card objects that represents the cards in the players hand
        /// </summary>
        public List<Card> CardList = new List<Card>();
        /// <summary>
        /// The amount of money the player has
        /// </summary>
        private decimal playerMoney = 1000.00m;
  
        /// <summary>
        /// Minimum amount you could bet
        /// </summary>
        public static decimal MinBet = 10.00m;
        /// <summary>
        /// The sum value of all the cards in the players hand
        /// </summary>
        public int handValue { get; set; } = 0;
        public int wins { get; set; } = 0;
        public decimal PlayerMoney { get { return playerMoney; } set { playerMoney = value; } }

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
                if (Card.value == 1)
                {
                    sum += 11;
                    softAces++;
                }
                else
                {
                    sum += Card.value;
                }
                while (sum > 21 && softAces > 0)
                {
                    softAces--;
                    sum -= 10;
                }
            }
            handValue = sum;
        }

        /// <summary>
        /// Checks if the player that called the function has a hand value over 21
        /// </summary>
        /// <returns></returns>
        public bool CheckBusted()
        {
            CalcuateCurrentHand();
            if (handValue > 21)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Hit Function for the players, also used by dealer
        /// </summary>
        public bool Hit(Deck deck)
        {
            // Deck call for next card
            CardList.Add(deck.GetNextCard());
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
        public bool Bet(decimal amount)
        {
            
            if(playerMoney-amount < 0)
            {
                // Insignifant Money
                // Display and cancel bet
                return false;
            }
            else
            {
                // Place Bet
                playerMoney -= amount;
                return true;
            }
        }

        /// <summary>
        /// Clears CardList, and sets hands to zero
        /// </summary>
        public void ClearHand()
        {
            CardList.Clear();
            handValue = 0;
        }
    }
}
