using DavesBlackjack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        // Command Object, Move to third sprint
        // XMLCommands XCom = new XMLCommands();

        // Error Messages
        public string EMPTY_USER_NAME = "Please enter a username";
        public string USER_ALREADY_EXISTS = "User already exists, try another username";
        public string PASSWORD_TOO_SHORT = "Password is too short, try a longer password";
        public string PASSWORD_MISMATCH = "Passwords do not match";
        public string PASSWORD_EMPTY = "Please enter password";
        public string PASSWORD_INVALID_CHARECTERS = "Password cannot contain spaces.";
        public string SECURITY_QUESTION_EMPTY = "Secuirty question cannot be blank.";
        public string USERNAME_INVAILD_CHARECTER = "Username cannot contain spaces.";
        public string FIX_ERRORS = "Fix Highlighted errors.";



        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string CreateNewUser()
        {
            // Build XML tree
            int currentUsers = doc.Descendants("Username").Count();
            XElement newUser = new XElement("Username",
                new XAttribute("id", currentUsers + 1),
                new XAttribute("uName", tbUsername.Text.ToLower()),
                new XAttribute("Password", HashPassword(tbPassword.Text)),
                new XElement("PlayerName", tbUsername.Text),
                new XElement("SecurityQuestions",
                    new XElement("Question", cbSecurityQuestion.Text ),
                    new XElement("Answer", tbSecuirtyQuestionAnswer.Text.ToLower())),
                new XElement("PaymentInfo",
                    new XElement("CardNumber", null),
                    new XElement("NameOnCard", null),
                    new XElement("SecurityCode",null),
                    new XElement("ExpireDate",null),
                    new XElement("BillingAddress", null),
                    new XElement("City", null),
                    new XElement("State", null),
                    new XElement("Zip", null),
                    new XElement("PhoneNumber",null)),
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
            MessageBox.Show("Successfully created user " + tbUsername.Text, "User Created!" );
            this.Close();
            return "Success";
        }

        public static string HashPassword(string plainPass)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // build hash
            var derive = new Rfc2898DeriveBytes(plainPass, salt, 10000);
            byte[] hash = derive.GetBytes(20);

            // Combine Salt/hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;


        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (CheckForErrors())
            {
                lblErrorsExist.Text = FIX_ERRORS;
                lblErrorsExist.Visible = true;

            }
            else
            {
                CreateNewUser();
                PaymentInfo AddPaymentInfo = new PaymentInfo(tbUsername.Text);
                AddPaymentInfo.Show();
            }
        }
        private bool CheckForErrors()
        {


            // check if errors exist
            if ( CheckForUsernameErrors() || CheckForPasswordErrors() || CheckForConfirmErrors() || CheckForSecuirtyErrors() )
            {
                // Run though error checks to display all errors
                CheckForUsernameErrors();
                CheckForPasswordErrors();
                CheckForConfirmErrors();
                CheckForSecuirtyErrors();
                //btnCreateAccount.Enabled = false;
                return true;
            }
            else
            {
                //btnCreateAccount.Enabled = true;
                return false;
            }
    
        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            cbSecurityQuestion.SelectedIndex = 0;
        }

        /// <summary>
        /// Checks if there are any username errors present
        /// </summary>
        /// <returns>
        /// true if there are errors
        /// false if there are no errors
        /// </returns>
        private bool CheckForUsernameErrors()
        {
            // Username
            if (tbUsername.Text == "")
            {
                lblUsernameError.Text = EMPTY_USER_NAME;
                lblUsernameError.Visible = true;
                pnlUsername.Visible = true;

                return true;
            }
            // Username contains invalid charectors. 
            else if (tbUsername.Text.Contains(" "))
            {
                lblUsernameError.Text = USERNAME_INVAILD_CHARECTER;
                lblUsernameError.Visible = true;
                pnlUsername.Visible = true;
                return true;
            }
            // Check if username is already used (case insesitive)
            else if (DoesUserExist(tbUsername.Text))
            {
                lblUsernameError.Text = USER_ALREADY_EXISTS;
                lblUsernameError.Visible = true;
                pnlUsername.Visible = true;
                return true;
            }
            // No username errors exist
            else
            {
                lblUsernameError.Text = "";
                pnlUsername.Visible = false;
                return false;
            }
        }
        public bool DoesUserExist(string username)
        {
            username = username.ToLower();
            var userExists = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Attribute("uName")).FirstOrDefault();

            if (userExists == null)
                return false;
            else
                return true;
        }


        /// <summary>
        /// Checks if there are password errors present.
        /// </summary>
        /// <returns>
        /// true if there are errors
        /// false if there are no errors
        /// </returns>
        private bool CheckForPasswordErrors()
        {
            // Password Validation
            if (tbPassword.Text == "")
            {
                // Password
                // Not Empty
                lblPasswordError.Text = PASSWORD_EMPTY;
                lblPasswordError.Visible = true;
                pnlPassword.Visible = true;
                return true;
            }
            // Minimum Length
            else if (tbPassword.Text.Length < 8)
            {
                lblPasswordError.Text = PASSWORD_TOO_SHORT;
                lblPasswordError.Visible = true;
                pnlPassword.Visible = true;
                return true;

            }
            // Check Password longer then 8 charecters and no spaces
            else if (tbPassword.Text.Contains(' '))
            {
                lblPasswordError.Text = PASSWORD_INVALID_CHARECTERS;
                lblPasswordError.Visible = true;
                pnlPassword.Visible = true;
                return true;

            }
            else
            {
                lblPasswordError.Text = "";
                pnlPassword.Visible = false;
                return false;
            }
        }
        /// <summary>
        /// Checks for second password errors
        /// </summary>
        /// <returns>
        /// true if there are errors
        /// false if there are no errors
        /// </returns>
        private bool CheckForConfirmErrors()
        {
            // Matches Second
            if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                lblConfirmError.Text = PASSWORD_MISMATCH;
                lblConfirmError.Visible = true;
                pnlConfirmPass.Visible = true;
                return true;

            }
            else
            {
                lblConfirmError.Text = "";
                pnlConfirmPass.Visible = false;
                return false;
            }
        }
        /// <summary>
        /// Checks if the user entred a secuirty error.
        /// </summary>
        /// <returns>
        /// true if there are errors
        /// false if there are no errors
        /// </returns>
        private bool CheckForSecuirtyErrors()
        {
            // Security Question
            if (tbSecuirtyQuestionAnswer.Text == "")
            {
                lblSecuirtyQuestionError.Text = SECURITY_QUESTION_EMPTY;
                lblSecuirtyQuestionError.Visible = true;
                pnlQuestionAnswer.Visible = true;
                return true;

            }
            else
            {
                lblSecuirtyQuestionError.Text = "";
                pnlQuestionAnswer.Visible = false;
                return false;
            }
        }

        private void tbSecuirtyQuestionAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateAccount.PerformClick();
            }
        }

        private void btnQuickFill_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "User01@gmail.com";
            tbUsername.Text = "User01";
            tbPassword.Text = "Password123";
            tbPasswordConfirm.Text = "Password123";
            tbSecuirtyQuestionAnswer.Text = "150";

        }
    }
}
