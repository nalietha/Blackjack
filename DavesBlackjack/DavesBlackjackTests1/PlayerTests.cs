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
    public class PlayerTests
    {
        [TestMethod()]
        public void Calculate_HandValue_For_5_Cards_Test()
        {
            //Arrange
            int ACE_OF_SPADES = 0;
            int TWO_OF_SPADES = 1;
            int THREE_OF_CLUBS = 28;
            int FOUR_OF_HEARTS = 42;
            int ACE_OF_DIAMONDS = 13;

            Player player = new Player();
            player.CardList.Add(new Card(ACE_OF_SPADES));
            player.CardList.Add(new Card(TWO_OF_SPADES));
            player.CardList.Add(new Card(THREE_OF_CLUBS));
            player.CardList.Add(new Card(FOUR_OF_HEARTS));
            player.CardList.Add(new Card(ACE_OF_DIAMONDS));

            //Act
            player.CalcuateCurrentHand();

            //Assert
            const int EXPECTED_RESULT = 21;
            Assert.AreEqual(EXPECTED_RESULT, player.handValue);
        }

        [TestMethod()]
        public void Check_For_Busted_With_5_Cards_Test()
        {
            //Arrange
            int ACE_OF_SPADES = 0;
            int TWO_OF_SPADES = 1;
            int THREE_OF_CLUBS = 28;
            int QUEEN_OF_SPADES = 11;
            int KING_OF_SPADES = 12;

            Player player = new Player();
            player.CardList.Add(new Card(ACE_OF_SPADES));
            player.CardList.Add(new Card(TWO_OF_SPADES));
            player.CardList.Add(new Card(THREE_OF_CLUBS));
            player.CardList.Add(new Card(QUEEN_OF_SPADES));
            player.CardList.Add(new Card(KING_OF_SPADES));

            //Act
            bool RESULT = player.CheckBusted();

            //Assert
            const bool EXPECTED_RESULT = true;
            Assert.AreEqual(EXPECTED_RESULT, RESULT);
        }

        [TestMethod()]
        public void Player_Recieves_Card_On_Hit_Test()
        {
            //Arrange
            Player player = new Player();
            Deck deck = new Deck();

            //Act
            player.Hit(deck);

            //Assert
            const int EXPECTED_RESULT = 1;
            Assert.AreEqual(EXPECTED_RESULT, player.CardList.Count());
        }
    }
}