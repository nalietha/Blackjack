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
        
        private static List<Card> _cards = new List<Card>();
        private const int CARDS_PER_DECK = 52;
        private int _currentIndex;


        public Deck()
        {
            this.InitializeDeck();
        }
       
        
        /// <summary>
        /// Initializes the deck by adding one of each card to the deck, and then shuffling the deck
        /// </summary>
        private void InitializeDeck()
        {
            _cards.Clear();
            for (int x = 0; x < CARDS_PER_DECK; x++ )
            {
                
                _cards.Add(new Card(x));
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
            while(_cards.Count != 0)
            {
                int num = rand.Next() % _cards.Count;
                ShuffledDeck.Add(_cards[num]);
                _cards.RemoveAt(num);
            }

            //Setting the new Deck
            _cards = ShuffledDeck;
            _currentIndex = 0;
        }

        /// <summary>
        /// Gets the next card in the deck or NULL if there is no next card.
        /// </summary>
        /// <returns>Returns a Card class of the next card or NULL if there is no next card</returns>
        public Card GetNextCard()
        {
            //No next card
            if (_currentIndex >= CARDS_PER_DECK)
                return null;

            //Get next card
            Card card = _cards[_currentIndex];
            _currentIndex++;
            return card;
        }

        /// <summary>
        /// Returns the number of Cards left in the Deck.
        /// </summary>
        /// <returns>An int of the number of Cards left</returns>
        public int GetNumOfCardsLeft()
        {
            return CARDS_PER_DECK - _currentIndex;
        }
    }
}
