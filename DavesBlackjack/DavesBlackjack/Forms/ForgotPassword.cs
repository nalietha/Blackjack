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
    public partial class ForgotPassword : Form
    {
        // Awful way to do this, use an email security code to be secure. or a Captua

        public ForgotPassword()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        public static string USERNAME_EMPTY = "Please enter a username.";
        public static string USERNAME_NOT_FOUND = "Username does not exist.";
        public static string PASSWORD_EMPTY = "New password cannot be blank.";
        public static string PASSWORD_INVALID_CHARECTORS = "Password cannot contain spaces";
        public static string PASSWORD_TOO_SHORT = "Password must be longer then 8 characters";
        public static string PASSWORDS_MISMATCH = "Passwords do not match";

        private static readonly string DatabaseFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack/Database.xml";
        static readonly XDocument doc = XDocument.Load(DatabaseFile);

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!CheckUsernameErrors())
            {
                // Fix Errors
                lblSecurityQuestion.Text = GetUserSecurityQuestion(tbUsernameRecovery.Text.ToLower());
                pnlSecQuestions.Visible = true;
                tbSQAnswer.Focus();
                tbUsernameRecovery.TabStop = false;
            }
        }

        private bool CheckUsernameErrors()
        {
            if(tbUsernameRecovery.Text == "")
            {
                pnlUsername.Visible = true;
                lblUserErrorDisplay.Text = USERNAME_EMPTY;
                lblUserErrorDisplay.Visible = true;
                return true;
            }
            else if(UserExists(tbUsernameRecovery.Text.ToLower()))
            {
                pnlUsername.Visible = true;
                lblUserErrorDisplay.Text = USERNAME_NOT_FOUND;
                lblUserErrorDisplay.Visible = true;
                return true;
            }
            else
            {
                tbUsernameRecovery.ReadOnly = true;
                btnEnter.Enabled = false;
                pnlUsername.Visible = false;
                lblUserErrorDisplay.Visible = false;
                return false;

            }

        }
        public bool CheckNewPasswordErrors()
        {
            // Empty Check
            if (tbNewPassword.Text == "")
            {
                pnlChangePasswordError.Visible = true;
                lblPasswordError.Text = PASSWORD_EMPTY;
                lblPasswordError.Visible = true;
                return true;
            }
            else if (tbNewPassword.Text.Contains(" "))
            {
                pnlChangePasswordError.Visible = true;
                lblPasswordError.Text = PASSWORD_INVALID_CHARECTORS;
                lblPasswordError.Visible = true;
                return true;
            }
            else if (tbNewPassword.Text.Length < 8)
            {
                pnlChangePasswordError.Visible = true;
                lblPasswordError.Text = PASSWORD_TOO_SHORT;
                lblPasswordError.Visible = true;
                return true;
            }
            else if (tbConfimPass.Text != tbNewPassword.Text)
            {
                pnlChangePasswordError.Visible = true;
                pnlConfirmPassError.Visible = true;
                lblPasswordError.Text = PASSWORDS_MISMATCH;
                lblPasswordError.Visible = true;
                return true;
            }
            else
            {
                pnlChangePasswordError.Visible = false;
                pnlConfirmPassError.Visible = false;
                lblPasswordError.Visible = false;
                return false;
            }
        }

        private bool UserExists(string username)
        {
            var userExists = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Attribute("uName")).FirstOrDefault();

            if (userExists == null)
                return true;
            else
                return false;
        }

        private void ChangePassword()
        {
            string username = tbUsernameRecovery.Text;
            var userChange = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username.ToLower()).FirstOrDefault();

            string newPass = CreateProfile.HashPassword(tbNewPassword.Text);

            userChange.SetAttributeValue("Password", newPass);

            doc.Save(DatabaseFile);
            // Display Message saying password has been changed
            //close form
            this.Close();
        }


        private string GetUserSecurityQuestion(string username)=> doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Element("SecurityQuestions").Element("Question")).FirstOrDefault();
        private string GetUserSecurityAnswer(string username) => doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Element("SecurityQuestions").Element("Answer")).FirstOrDefault();

        private void btnSQEnter_Click(object sender, EventArgs e)
        {
            if(GetUserSecurityAnswer(tbUsernameRecovery.Text.ToLower()) == tbSQAnswer.Text.ToLower())
            {
                pnlPasswordDisplay.Visible = true;
                tbSQAnswer.ReadOnly = true;
                tbSQAnswer.TabStop = false;
                tbNewPassword.Focus();
                pnlSecurityQuestionError.Visible = false;
                lblSQError.Visible = false;
                btnSQEnter.Enabled = false;
            }
            else
            {
                pnlSecurityQuestionError.Visible = true;
                lblSQError.Visible = true;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUsernameRecovery_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnEnter.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSQEnter.PerformClick();
        }

        private void tbChangePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnChangePass.PerformClick();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if(!CheckNewPasswordErrors())
            {
                pnlChangePasswordError.Visible = false;
                lblPasswordError.Visible = false;
                ChangePassword();
                this.Close();
            }

        }

        private void btnNewPassShow_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.UseSystemPasswordChar == true)
                tbNewPassword.UseSystemPasswordChar = false;
            else
                tbNewPassword.UseSystemPasswordChar = true;

        }

        private void btnConfirmPassShow_Click(object sender, EventArgs e)
        {
            if (tbConfimPass.UseSystemPasswordChar == true)
                tbConfimPass.UseSystemPasswordChar = false;
            else
                tbConfimPass.UseSystemPasswordChar = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
