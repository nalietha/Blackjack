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
using DavesBlackjack.Classes;
using DavesBlackjack.Properties;

namespace DavesBlackjack
{
    public partial class TitleForm : Form
    {
        private bool validated = false;
        public string username { get { return tbUsername.Text; } }
        public Music Music;

        public TitleForm()
        {
            InitializeComponent();
            addingPlayerFlag = false;
            Music = new Music();
        }

        // New player form init
        public TitleForm(bool newPlayerFlag)
        {
            InitializeComponent();
            if (newPlayerFlag)
                btnCancelNewPlayer.Text = "Cancel";
            addingPlayerFlag = true;
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
            tbPassword.Text = "";
            tbUsername.Text = "";
            AddNewPlayer = null;
            if (Music.isPlaying)
            {
                muteButton.BackgroundImage = Resources.soundOn;
            }
            else
            {
                muteButton.BackgroundImage = Resources.soundOff;
            }
        }
        
        private readonly string DatabaseFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack//Database.xml";
        private readonly string LOGIN_FAILED = "Login Failed";
        private readonly string BLANK_USERNAME = "Username cannot be blank";
        private readonly bool addingPlayerFlag;

        public Player AddNewPlayer { get; private set; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Validate stuff
            validated = true;
            string savedPasswordHash = null;

            if (tbUsername.Text.Replace(" ","") == "")
            {
                lblError.Text = BLANK_USERNAME;
                validated = false;
            }
            else
                savedPasswordHash = GetPassword(tbUsername.Text.ToLower());
            // Check if User exists
                

            if (savedPasswordHash == null )
            {
                validated = false;
            }
            else
            {
            /* Fetch the stored value */    
                /* Extract the bytes */
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

                /* Get the salt */
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);

                /* Compute the hash on the password the user entered */
                var pbkdf2 = new Rfc2898DeriveBytes(tbPassword.Text, salt, 10000);

                byte[] hash = pbkdf2.GetBytes(20);
                /* Compare the results */
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        validated = false;
            }
            

            //Classes.User currentUser = new Classes.User();

            if (validated && !addingPlayerFlag)
            {
                // Open Game 
                // Make form Invisable. 
                this.Visible = false;
                GameBoard gameBoard = new GameBoard(this.tbUsername.Text)
                {
                    Music = Music
                };
                gameBoard.Show();
            }
            else if(validated && addingPlayerFlag)
            {
                this.AddNewPlayer = new Player(tbUsername.Text);
                //Create new player Object and return it to main form
                Close();
            }
            else
            {
                lblError.Text = LOGIN_FAILED;
                lblError.Visible = true;

            }
            
        }

        public string GetPassword(string username)
        {

            // Open DB file
            XDocument doc = XDocument.Load(DatabaseFile);
            var pass = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == username).Select(x => (string)x.Attribute("Password")).FirstOrDefault();
            if (pass != null)
                return pass;
            else
                return null;
        }
        
        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPassword fForm = new ForgotPassword();
            Hide();
            fForm.ShowDialog();
            Show();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            Hide();
            createProfile.ShowDialog();
            Show();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if(Music.isPlaying)
            {
                Music.Stop();
                muteButton.BackgroundImage = Resources.soundOff;
            }
            else
            {
                Music.Resume();
                muteButton.BackgroundImage = Resources.soundOn;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            Music.Skip();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void btnCancelNewPlayer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.credits + Environment.NewLine + Environment.NewLine + Properties.Resources.licenses, "Credits and Licenses", MessageBoxButtons.OK);
        }
    }
}