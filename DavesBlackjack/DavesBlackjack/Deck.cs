using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    /// <summary>
    /// Holds the 52 cards used during gameplay
    /// </summary>
    class Deck
    {
        /// <summary>
        /// List of cards using the Card class
        /// </summary>
        private List<Card> Cards;
        public Deck()
        {
            this.InitializeDeck();
        }
        /// <summary>
        /// Initializes the deck by adding one of each card to the deck, and then shuffling the deck
        /// </summary>
        public void InitializeDeck()
        {
            for (int x = 0; x <= 51; x++ )
            {
                this.Cards.Clear();
                this.Cards.Add(new Card(x));
            }

            //Shuffling the deck goes here
        }
    }
}
