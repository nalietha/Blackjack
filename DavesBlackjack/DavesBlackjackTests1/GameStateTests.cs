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
            GameState gamestate = new GameState(new Dealer(), new Player(), new Deck(), 25, true);
            string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack Saves//";

            //Act
            gamestate.SaveGame("Test", SaveFilePath);

            //Assert
            Assert.AreEqual(true, System.IO.File.Exists(SaveFilePath + "Test.xml"));
            if(System.IO.File.Exists(SaveFilePath + "Test.xml"))
            {
                System.IO.File.Delete(SaveFilePath + "Test.xml");
            }
        }
    }
}