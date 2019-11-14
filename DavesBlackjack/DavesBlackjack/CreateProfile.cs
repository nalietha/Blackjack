using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DavesBlackjack
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }
        private string DatabaseFile = "Database.xml";

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Error Messages
        public string EMPTY_USER_NAME = "Please enter a username";
        public string USER_ALREADY_EXISTS = "ERROR: User already exists, try another username";
        public string PASSWORD_TOO_SHORT = "Password is too short, try a longer password";
        public string PASSWORD_MISMATCH = "Passwords do not match";
        public string PASSWORD_EMPTY = "Please enter password";


        public string CreateNewUser()
        {
            string saltVal = "Hello";
            XDocument doc = XDocument.Load(DatabaseFile);

            // Check if boxes are filled.
            // Username
            if (tbUsername.Text == "") 
                return EMPTY_USER_NAME;

            // Check if username is already used (case insesitive)
           /* if (tbUsername.Text.ToLower() == *//*search*//*)
                return USER_ALREADY_EXISTS;*/


            // Password
            // Not Empty
            if (tbPassword.Text == "")
            {
                return PASSWORD_MISMATCH;
            }
            // Minimum Length

            // Matches Second

            // Security Question

            // Check Password longer then 8 charecters and no spaces

            // Hash Password

            // Add User to XML Database
            // Open document

            // Build XML tree
            // Generate Salt for user

            int currentUsers = doc.Descendants("Users").Count();
            XElement newUser = new XElement("Username",
                new XAttribute("id", currentUsers + 1),
                new XAttribute("uName", tbUsername),
                new XAttribute("Salt", saltVal),
                new XAttribute("password", tbPassword.GetHashCode()),
                new XElement("SecurityQuestions",
                    new XElement("Question"),
                    new XElement("Answer")),
                new XElement("PaymentInfo",
                    new XElement("CardNumber"),
                    new XElement("NameOnCard"),
                    new XElement("SecurityCode"),
                    new XElement("ExpireDate")),
                new XElement("GamesWon"),
                new XElement("Cash"),
                new XElement("GameInProgress",
                    new XElement("Status"),
                    new XElement("SaveState"))
                );

            // Load into Root Users
            doc.Root.Element("Users").Add(newUser);




            // If any errors are present, return "Failure" with msg.


            return "Success";
        }


    }
}
