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
        

        private static string DatabaseFile = "..\\..\\Database.xml";
        XDocument doc = XDocument.Load(DatabaseFile);

        // Error Messages
        public string EMPTY_USER_NAME = "Please enter a username";
        public string USER_ALREADY_EXISTS = "ERROR: User already exists, try another username";
        public string PASSWORD_TOO_SHORT = "Password is too short, try a longer password";
        public string PASSWORD_MISMATCH = "Passwords do not match";
        public string PASSWORD_EMPTY = "Please enter password";
        public string PASSWORD_INVALID_CHARECTERS = "Password cannot contain spaces.";
        public string SECURITY_QUESTION_EMPTY = "Secuirty question cannot be blank.";
        public string USERNAME_INVAILD_CHARECTER = "Username cannot contain spaces.";

        public void DebugUser()
        {
            tbUsername.Text = "NaLietha";
            tbPassword.Text = "Password1!";
            tbPasswordConfirm.Text = "Password1!";
            tbSecuirtyQuestionAnswer.Text = "Answer";
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string CreateNewUser()
        {
            string saltVal = "Hello";

            // Hash Password
            var hashPass = tbPassword.Text;

            // Build XML tree
            // Generate Salt for user

            int currentUsers = doc.Descendants("Users").Count();
            XElement newUser = new XElement("Username",
                new XAttribute("id", currentUsers + 1),
                new XAttribute("uName", tbUsername.Text.ToLower()),
                new XAttribute("Salt", saltVal),
                new XAttribute("password", tbPassword.Text),
                new XElement("PlayerName", tbUsername.Text),
                new XElement("SecurityQuestions",
                    new XElement("Question", cbSecurityQuestion.SelectedValue.ToString() ),
                    new XElement("Answer", tbSecuirtyQuestionAnswer.Text)),
                new XElement("PaymentInfo",
                    new XElement("CardNumber", null),
                    new XElement("NameOnCard", null),
                    new XElement("SecurityCode",null),
                    new XElement("ExpireDate",null)),
                new XElement("GamesWon", 0),
                new XElement("Cash", 0),
                new XElement("GameInProgress",
                    new XElement("Status", false),
                    new XElement("PlayerSave",
                        new XElement("SaveState"),
                    new XElement("DealerSave"),
                        new XElement("SaveState"))
                ));

            // Load into Root Users
            doc.Root.Add(newUser);
            doc.Save(DatabaseFile);

            // If any errors are present, return "Failure" with msg.
            MessageBox.Show("User Created!", "Successfully created user " + tbUsername.Text);
            this.Close();
            return "Success";
        }
        private void ResetErrors()
        {
            // labels



            // Panels
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateNewUser();

        }
        private void CheckForErrors()
        {
            bool errorsExist = false;
            // Reset Errors
            ResetErrors();
            // Username
            if (tbUsername.Text == "")
            {
                lblUsernameError.Text = EMPTY_USER_NAME;
                lblUsernameError.Visible = true;
                pnlUsername.BackColor = Color.Red;
                errorsExist = true;
            }
            else if (tbUsername.Text.Contains(" "))
            {
                lblUsernameError.Text = USERNAME_INVAILD_CHARECTER;
                lblUsernameError.Visible = true;
            }
            // Check if username is already used (case insesitive)
            else if (FindUser(tbUsername.Text))
            {
                lblUsernameError.Text = USER_ALREADY_EXISTS;
                lblUsernameError.Visible = true;
                errorsExist = true;
            }
            else if (tbPassword.Text == "")
            {
                // Password
                // Not Empty
                lblPasswordError.Text = PASSWORD_MISMATCH;
                lblPasswordError.Visible = true;
                errorsExist = true;
            }
            // Minimum Length
            else if (tbPassword.Text.Length < 8)
            {
                lblPasswordError.Text = PASSWORD_TOO_SHORT;
                lblPasswordError.Visible = true;
                errorsExist = true;

            }
            // Check Password longer then 8 charecters and no spaces
            else if (tbPassword.Text.Contains(' '))
            {
                lblPasswordError.Text = PASSWORD_INVALID_CHARECTERS;
                lblPasswordError.Visible = true;
                errorsExist = true;

            }
            // Matches Second
            else if (tbPassword.Text == tbPasswordConfirm.Text)
            {
                lblConfirmPassword.Text = PASSWORD_MISMATCH;
                lblConfirmPassword.Visible = true;
                errorsExist = true;

            }
            // Security Question
            else if (tbSecuirtyQuestionAnswer.Text == "")
            {
                lblSecuirtyQuestionError.Text = SECURITY_QUESTION_EMPTY;
                lblSecuirtyQuestionError.Visible = true;
                errorsExist = true;

            }

            if (!errorsExist)
                btnCreateAccount.Enabled = false;
            else
                btnCreateAccount.Enabled = true;
    

        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            cbSecurityQuestion.SelectedIndex = 0;
        }
        /// <summary>
        /// Finds if username exists in database
        /// </summary>
        /// <param name="name">Name to check for, make lowercase for seach compare. stored as userentered.</param>
        /// <returns>boolen</returns>
        private bool FindUser(string name)
        {
            var user = doc.Descendants("Users").Where(s => (string)s.Attribute("Username") == name.ToLower());


            return false;
        }

        private void btnDebugPopulate_Click(object sender, EventArgs e)
        {
            DebugUser();
        }
    }
}
