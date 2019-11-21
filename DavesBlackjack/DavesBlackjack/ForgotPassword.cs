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

        private static string DatabaseFile = "..\\..\\Database.xml";
        static XDocument doc = XDocument.Load(DatabaseFile);


        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (CheckUsernameErrors())
            {
                // Fix Errors
            }
            else
            {
                lblSecurityQuestion.Text = GetUserSecurityQuestion(tbUsernameRecovery.Text.ToLower());
                pnlSecQuestions.Visible = true;
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



        private bool UserExists(string username)
        {
            var userExists = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Attribute("uName")).FirstOrDefault();

            if (userExists == null)
                return true;
            else
                return false;
        }


        private string GetUserSecurityQuestion(string username)=> doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Element("SecurityQuestions").Element("Question")).FirstOrDefault();
        private string GetUserSecurityAnswer(string username) => doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Element("SecurityQuestions").Element("Answer")).FirstOrDefault();

        private void btnSQEnter_Click(object sender, EventArgs e)
        {
            if(GetUserSecurityAnswer(tbUsernameRecovery.Text.ToLower()) == tbSQAnswer.Text.ToLower())
            {
                
                pnlPasswordDisplay.Visible = true;
            }
        }
        private bool CheckAnswer()
        {
            // Empty Check

            // Compare to saved answer
            throw new NotImplementedException();
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





    }
}
