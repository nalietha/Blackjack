using DavesBlackjack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DavesBlackjack
{

    public class Player 
    {
        public static string DatabaseFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack//Database.xml";
        readonly XDocument doc = XDocument.Load(DatabaseFile);
        /// <summary>
        /// A list of card objects that represents the cards in the players hand
        /// </summary>
        public List<Card> CardList = new List<Card>();
        /// <summary>
        /// Minimum amount you could bet
        /// </summary>
        public static decimal MinBet = 10.00m;
        public User user;
        /// <summary>
        /// The sum value of all the cards in the players hand
        /// </summary>
        /// 
        public int handValue { get; set; } = 0;
        public int wins { get; set; } = 0;
        public int losses { get; set; } = 0;
        public decimal PlayerMoney { get; set; } = 0.00m;
        public int currentBet { get; set; } = 10;
        public int insurance { get; set; } = 0;
        public bool done = false;
        public bool isSplitHand = false;
        public int playerNum;
        public int originalMoney;
        public bool aces = false;

        public Player()
        {
            //this._username = GetUsername();
            //this._playerWins = GetPlayerWins();

            CalcuateCurrentHand();
        }
        public Player(string username)
        {
            user = new User(username);
            PlayerMoney = Convert.ToDecimal(user.money);
            wins = Convert.ToInt32(user.gamesWon);
        }

        /// <summary>
        /// Gets the value that the player currently has in their hand
        /// Called at the start of each round
        /// </summary>
        /// <returns>sum of the cards in hand</returns>
        public void CalcuateCurrentHand()
        {
            int sum = 0;
            int softAces = 0;

            foreach (var Card in CardList)
            {
                if (Card.value == 1)
                {
                    sum += 11;
                    softAces++;
                }
                else
                {
                    sum += Card.value;
                }
                while (sum > 21 && softAces > 0)
                {
                    softAces--;
                    sum -= 10;
                }
            }
            handValue = sum;
        }

        /// <summary>
        /// Checks if the player that called the function has a hand value over 21
        /// </summary>
        /// <returns></returns>
        public bool CheckBusted()
        {
            CalcuateCurrentHand();
            if (handValue > 21)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Hit Function for the players, also used by dealer
        /// </summary>
        public bool Hit(Deck deck)
        {
            // Deck call for next card
            CardList.Add(deck.GetNextCard());
            CalcuateCurrentHand();
            return CheckBusted();
        }

        /// <summary>
        /// Stay function, used by player and dealer
        /// </summary>
        public void Stay()
        {
            // Go to next player choice
            // not needed
        }

        /// <summary>
        /// Bet function for the player to increase his bet.
        /// </summary>
        /// <param name="amount">amount the player is betting.</param>
        public bool Bet(decimal amount)
        {
            
            if(PlayerMoney-amount < 0)
            {
                // Insignifant Money
                // Display and cancel bet
                return false;
            }
            else
            {
                // Place Bet
                PlayerMoney -= amount;
                return true;
            }
        }

        /// <summary>
        /// Clears CardList, and sets hands to zero
        /// </summary>
        public void ClearHand()
        {
            CardList.Clear();
            handValue = 0;
        }

        /// <summary>
        /// Updates the XML Database with the current info of the user being logged out
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void LogOutUser()
        {
            string username = user.username;
            var userChange = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username.ToLower()).FirstOrDefault();

            string newCash = PlayerMoney.ToString();
            string newWins = wins.ToString();

            userChange.SetElementValue("Cash", newCash);
            userChange.SetElementValue("GamesWon", newWins);

            doc.Save(DatabaseFile);
        }
        
        //public string GetUsername() => doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == _username.ToLower()).Select(x => (string)x.Element("GamesWon")).FirstOrDefault();
        //public string GetPlayerWins() => doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == _username.ToLower()).Select(x => (string)x.Element("GamesWon")).FirstOrDefault();
        //public string GetCurrentMoneyCount() => doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == _username.ToLower()).Select(x => (string)x.Element("Cash")).FirstOrDefault();
    }
}