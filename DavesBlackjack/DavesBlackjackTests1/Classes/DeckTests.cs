using Microsoft.VisualStudio.TestTools.UnitTesting;
using DavesBlackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void Null_When_Dealing_From_Empty_Deck_Test()
        {
            //Arrange
            Deck deck = new Deck();
            deck._cards.Clear();

            //Act
            Card drawnCard = deck.GetNextCard();

            //Assert
            Card EXPECTED_RESULT = null;
            Assert.AreEqual(EXPECTED_RESULT, drawnCard);
        }

        [TestMethod()]
        public void Shuffe_All_Cards_In_Deck_Test()
        {
            //Arrange
            Deck unshuffledDeck = new Deck();
            Deck deckToShuffle = new Deck();

            //Act
            deckToShuffle.Shuffle();

            //Assert
            const bool EXPECTED_RESULT = false;
            bool RESULT = true;

            for(int i = 0; i < 52; i++)
            {
                if (unshuffledDeck._cards[i].id == deckToShuffle._cards[i].id)
                    RESULT = false;
            }

            Assert.AreEqual(EXPECTED_RESULT, RESULT);
        }
    }
}