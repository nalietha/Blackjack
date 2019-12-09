using System;
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
            XDocument doc = XDocument.Load("..\\..\\Database.xml");
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

        private string GetID()
        {
            return this.currentUser.Element("Username").Attribute("id").Value;
        }
        private string GetGamesWon()
        {
            return this.currentUser.Element("Username").Attribute("id").Value;

        }
        private string GetMoney() => this.currentUser.Element("Cash").Value;
        private string GetEmail() => this.currentUser.Element("Email").Value;
        private string GetNameOnCard() => this.currentUser.Element("PaymentInfo").Element("NameOnCard").Value;
        private string GetCardNumber() => this.currentUser.Element("PaymentInfo").Element("CardNumber").Value;
        private string GetCardExpires() => this.currentUser.Element("PaymentInfo").Element("ExpireDate").Value;
        private string GetCity() => this.currentUser.Element("PaymentInfo").Element("City").Value;
        private string GetState() => this.currentUser.Element("PaymentInfo").Element("State").Value;
        private string GetBillingAddress() => this.currentUser.Element("PaymentInfo").Element("BillingAddress").Value;
        private string GetZip() => this.currentUser.Element("PaymentInfo").Element("Zip").Value;
        private string GetPhoneNumber() => this.currentUser.Element("PaymentInfo").Element("PhoneNumber").Value;









    }
}
