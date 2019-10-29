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
        
        private List<Card> Cards;
        private const int CARDS_PER_DECK = 52;
        private int CurrentIndex;


        public Deck()
        {
            this.InitializeDeck();
        }
       
        
        /// <summary>
        /// Initializes the deck by adding one of each card to the deck, and then shuffling the deck
        /// </summary>
        private void InitializeDeck()
        {
            this.Cards.Clear();
            for (int x = 0; x < CARDS_PER_DECK; x++ )
            {
                
                this.Cards.Add(new Card(x));
            }

            //Shuffling the deck goes here
            Shuffle();
        }


        /// <summary>
        /// Sets the DeckInUse array as a shuffled version of the cards array
        /// </summary>
        public void Shuffle()
        {
            //Temporary new deck to store the shuffled deck
            List<Card> ShuffledDeck = new List<Card>();
            //random number generator
            Random rand = new Random();


            //Shuffling the Deck into ShuffledDeck
            while(Cards.Count != 0)
            {
                int num = rand.Next() % Cards.Count;
                ShuffledDeck.Add(Cards[num]);
                Cards.RemoveAt(num);
            }

            //Setting the new Deck
            Cards = ShuffledDeck;
            CurrentIndex = 0;
        }

        /// <summary>
        /// Gets the next card in the deck or NULL if there is no next card.
        /// </summary>
        /// <returns>Returns a Card class of the next card or NULL if there is no next card</returns>
        public Card GetNextCard()
        {
            //No next card
            if (CurrentIndex >= CARDS_PER_DECK)
                return null;

            //Get next card
            Card card = Cards[CurrentIndex];
            CurrentIndex++;
            return card;
        }

        /// <summary>
        /// Returns the number of Cards left in the Deck.
        /// </summary>
        /// <returns>An int of the number of Cards left</returns>
        public int GetNumOfCardsLeft()
        {
            return CARDS_PER_DECK - CurrentIndex;
        }
    }
}
