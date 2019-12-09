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
        public void Write_XML_File_From_GameState_Test()
        {
            //Arrange
            const int CURRENT_BET = 25;
            const bool IS_BEFORE_INSURANCE = true;

            GameState gamestate = new GameState(new Dealer(), new Player(), new Deck(), CURRENT_BET, IS_BEFORE_INSURANCE);
            string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack Saves//";

            //Act
            gamestate.SaveGame("Test", SaveFilePath);

            //Assert
            const bool EXPECTED_RESULT = true;

            Assert.AreEqual(EXPECTED_RESULT, System.IO.File.Exists(SaveFilePath + "Test.xml"));
            if(System.IO.File.Exists(SaveFilePath + "Test.xml"))
            {
                System.IO.File.Delete(SaveFilePath + "Test.xml");
            }
        }
    }
}