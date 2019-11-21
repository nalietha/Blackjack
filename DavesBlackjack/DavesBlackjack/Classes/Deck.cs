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
        /// A list of card objects that represents the cards in the deck
        /// </summary>
        private static List<Card> _cards = new List<Card>();
        /// <summary>
        /// The maximum number of cards per deck
        /// </summary>
        private const int CARDS_PER_DECK = 52;

        public Deck()
        {
            Shuffle();
        }

        /// <summary>
        /// Sets the DeckInUse array as a shuffled version of the cards array
        /// </summary>
        public static void Shuffle()
        {
            //Clear all the cards
            _cards.Clear();

            //Add in one of every card
            for (int x = 0; x < CARDS_PER_DECK; x++)
            {
                _cards.Add(new Card(x));
            }

            //Temporary new deck to store the shuffled deck
            List<Card> ShuffledDeck = new List<Card>();

            //Random number generator
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
        }

        /// <summary>
        /// Gets the next card in the deck or NULL if there is no next card.
        /// </summary>
        /// <returns>Returns a Card class of the next card or NULL if there is no next card</returns>
        public static Card GetNextCard()
        {
            //No next card
            if (_cards.Count == 0)
                return null;

            //Get next card
            Card card = _cards.First();
            _cards.Remove(_cards.First());
            return card;
        }

        public static void SetDeck(List<Card> deck)
        {
            _cards = deck;
        }
    }
}
