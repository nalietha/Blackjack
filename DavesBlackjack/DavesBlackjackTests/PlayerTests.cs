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
        public void Calcuate_CurrentHand_For_5_Cards_Test()
        {
            //Arrange
            Player player = new Player();
            player.CardList.Add(new Card(0));  // Ace of Spades
            player.CardList.Add(new Card(14)); // 2 of Diamonds
            player.CardList.Add(new Card(28)); // 3 of Clubs
            player.CardList.Add(new Card(42)); // 4 of Hearts
            player.CardList.Add(new Card(39)); // Ace of Hearts

            //Act
            player.CalcuateCurrentHand();

            //Assert
            Assert.AreEqual(21, player.handValue);
        }

        [TestMethod()]
        public void Check_For_Busted_With_Five_Cards_Test()
        {
            //Arrange
            Player player = new Player();
            player.CardList.Add(new Card(0));  // Ace of Spades
            player.CardList.Add(new Card(17)); // 5 of Diamonds
            player.CardList.Add(new Card(29)); // 4 of Clubs
            player.CardList.Add(new Card(41)); // 3 of Hearts
            player.CardList.Add(new Card(38)); // King of Clubs

            //Act
            bool result = player.CheckBusted();

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}