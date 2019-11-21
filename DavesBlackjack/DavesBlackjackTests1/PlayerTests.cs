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
            Player player = new Player();
            player.CardList.Add(new Card(0));  // Ace of Spades
            player.CardList.Add(new Card(1));  // 2 of Spades
            player.CardList.Add(new Card(28)); // 3 of Clubs 
            player.CardList.Add(new Card(42)); // 4 of Hearts
            player.CardList.Add(new Card(13)); // Ace of Diamonds

            //Act
            player.CalcuateCurrentHand();

            //Assert
            Assert.AreEqual(21, player.handValue);
        }

        [TestMethod()]
        public void Check_For_Busted_With_5_Cards_Test()
        {
            //Arrange
            Player player = new Player();
            player.CardList.Add(new Card(0));  // Ace of Spades
            player.CardList.Add(new Card(1));  // 2 of Spades
            player.CardList.Add(new Card(28)); // 3 of Clubs
            player.CardList.Add(new Card(11)); // Queen of Spades
            player.CardList.Add(new Card(12)); // King of Spades

            //Act
            bool result = player.CheckBusted();

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}