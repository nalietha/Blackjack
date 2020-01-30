﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DavesBlackjack.Classes
{
    /// <summary>
    /// Gets and saves all data on the user
    /// </summary>
    public partial class User
    {
        public User(string username)
        {
            string DatabaseFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack//Database.xml";
            XDocument doc = XDocument.Load(DatabaseFile);
            this.currentUser = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username.ToLower()).FirstOrDefault();
            
            this.username = username;
            this.id = GetID();
            this.gamesWon = GetGamesWon();
            this.money = GetMoney();
            this.email = GetEmail();
            this.cardName = GetNameOnCard();
            this.cardNumber = GetCardNumber();
            this.cardExpireDate = GetCardExpires();
            this.phoneNumber = GetPhoneNumber();
            this.city = GetCity();
            this.state = GetState();
            this.zip = GetZip();
            this.Address = GetBillingAddress();

        }

        /// <summary>
        /// Parameterless constructor used by the XMLWriter
        /// </summary>
        public User()
        { 
        
        }

        XElement currentUser;
        public string username;
        public string id;
        public string gamesWon;
        public string money;
        public string email;
        public string cardName;
        public string cardNumber;
        public string cardExpireDate;
        public string phoneNumber;
        public string city;
        public string state;
        public string zip;
        public string Address;

        private string GetID() => currentUser == null ? "" : this.currentUser.Attribute("id").Value;
        private string GetGamesWon() => currentUser == null ? "" : this.currentUser.Element("GamesWon").Value;
        private string GetMoney() => currentUser == null ? "" : this.currentUser.Element("Cash").Value;
        private string GetEmail() => currentUser == null ? "" : this.currentUser.Element("Email").Value;
        private string GetNameOnCard() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("NameOnCard").Value;
        private string GetCardNumber() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("CardNumber").Value;
        private string GetCardExpires() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("ExpireDate").Value;
        private string GetCity() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("City").Value;
        private string GetState() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("State").Value;
        private string GetBillingAddress() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("BillingAddress").Value;
        private string GetZip() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("Zip").Value;
        private string GetPhoneNumber() => currentUser == null ? "" : this.currentUser.Element("PaymentInfo").Element("PhoneNumber").Value;

        private void UpdateGameWins(int currentWins)
        {
            XElement wonGames = this.currentUser.Element("GamesWon");
            int savedWins = Int32.Parse(this.gamesWon);


            wonGames.SetElementValue("GamesWon", (currentWins + savedWins).ToString());
           
        }







    }
}
