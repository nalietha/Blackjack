using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DavesBlackjack
{
    class User
    {
        public User(string username, string hPass)
        {
            _username = username;
            _hPass = hPass;
        }

        public string _username;
        private string _hPass;
        public string database = "Database.xml";



        public string GetUsername()
        {

            return this._username;
        }


        public decimal GetUserMoney()
        {
            // Parse XML file with username to find amount of cash the the user has left


            return (decimal)1000.00;
        }
        public int GetUserGameWins()
        {
            // 



            return 0;
        }
        public bool GetSavedGame()
        {
            // Check if there is a saved game
            if (true)
                return false;
            // Saved deck

            // Get users saved game card sets
            // Hand
            GetPlayersHand();

            // Get dealers saved game card sets
            // Hand
            GetDealersHand();
            return true;
        }
        public List<Card> GetPlayersHand()
        {

            return null;
        }

        public List<Card> GetDealersHand()
        {
            return null;

        }

        public bool ChangeUserPassword()
        {
            // Ask for current password

            // if unknown ask them for their security question.
            return false;
        }


    }
}
