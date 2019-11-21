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
    public class GameStateTests
    {
        [TestMethod()]
        public void Use_GameState_To_Make_An_XML_Save_File_Test()
        {
            //Arrange
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack Saves//";
            GameState gamestate = new GameState();
            gamestate.dealer = new Dealer();
            gamestate.player = new Player();
            gamestate.deck = new Deck();
            gamestate.bet = 25;
            gamestate.beforeInsurance = true;

            //Act
            gamestate.SaveGame("Test", filepath);

            //Assert
            Assert.AreEqual(true, System.IO.File.Exists(filepath + "Test.xml"));

            //Clean Up
            if(System.IO.File.Exists(filepath + "Test.xml"))
                System.IO.File.Delete(filepath + "Test.xml");
        }
    }
}