using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    /// <summary>
    /// Used to serialize the game into an XML file.
    /// </summary>
    public class GameState
    {
        public Dealer dealer;
        public Player player;
        public Deck deck;
        public decimal bet = 0;
        public bool beforeInsurance;

        /// <summary>
        /// Constructor used for creating a game state
        /// </summary>
        /// <param name="dealer">Dealer object</param>
        /// <param name="player">Player Object</param>
        /// <param name="bet">Current Bet during game</param>
        /// <param name="beforeInsurance">Check if there is insurance</param>
        public GameState(Dealer _dealer, Player _player, Deck _deck, decimal _bet, bool _beforeInsurance)
        {
            dealer = _dealer;
            player = _player;
            deck = _deck;
            bet = _bet;
            beforeInsurance = _beforeInsurance;
        }
        /// <summary>
        /// Empty constructor for the XMLWriter
        /// </summary>
        public GameState()
        {

        }

        /// <summary>
        /// Writes an XML file to the specified filepath
        /// </summary>
        /// <param name="SaveFileName">Name of the save file</param>
        /// <param name="SaveFilePath">Path of the folder to save in</param>
        public void SaveGame(string SaveFileName, string SaveFilePath)
        {
            string pathString = SaveFilePath;
            System.IO.Directory.CreateDirectory(pathString);
            Type[] extratypes = new Type[0];

            var path = SaveFilePath + SaveFileName + ".xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            System.Xml.Serialization.XmlSerializer XMLWriter =
                new System.Xml.Serialization.XmlSerializer(typeof(GameState), extratypes);
            XMLWriter.Serialize(file, this);
            file.Close();
        }
    }
}
