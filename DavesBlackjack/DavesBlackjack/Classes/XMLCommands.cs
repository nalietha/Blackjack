using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DavesBlackjack.Classes
{
    /// <summary>
    /// Collenction of functions that will retreave information from specified user, only
    /// Needs User ID and username.
    /// </summary>
    abstract class XMLCommands
    {
        private static readonly string DatabaseFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack//Database.xml";
        readonly XDocument doc = XDocument.Load(DatabaseFile);

        public bool DoesUserExist(string username)
        {
            username = username.ToLower();
            var userExists = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Attribute("uName")).FirstOrDefault();

            if (userExists == null)
                return false;
            else
                return true;
        }

        //public string FindUsername(string username)

        //public string GetPlayerWins(string username)

        //public string GetPaymentInfo()

        //public bool ChangePassword(string username, string newPass)
        //{
        //    username = username.ToLower();
        //    var getChild = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x.Element).FirstOrDefault();
        //}

        //public bool ChangeUsername()

        //public bool ChangePaymentInfo()

        //public bool DeleteUser()

        //public bool 
    }
}
