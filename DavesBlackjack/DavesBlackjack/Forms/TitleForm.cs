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

namespace DavesBlackjack
{
    public partial class TitleForm : Form
    {
        
        GameBoard gameBoard;
        private bool validated = false;
        public string username { get { return tbUsername.Text; } }
        private readonly Music Music;

        public TitleForm()
        {
            InitializeComponent();
            addingPlayerFlag = false;
            this.Music = new Music();
        }
        // New player form init
        public TitleForm(bool newPlayerFlag)
        {
            InitializeComponent();
            this.addingPlayerFlag = true;
            btnCancelNewPlayer.Visible = true;


        }


        private void TitleForm_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
            tbPassword.Text = "";
            tbUsername.Text = "";
            this.newPlayer = null;
        }
        private string DatabaseFile = "..\\..\\Database.xml";
        private string LOGIN_FAILED = "Login Failed";
        private string BLANK_USERNAME = "Username cannot be blank";
        private bool addingPlayerFlag;
        Player newPlayer;
        public Player AddNewPlayer
        {
            get
            {
                return this.newPlayer;
            }
        }

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
                GameBoard gameBoard = new GameBoard(this.tbUsername.Text);
                gameBoard.Show();

            }
            else if(validated && addingPlayerFlag)
            {
                this.newPlayer = new Player(tbUsername.Text);
                //Create new player Object and return it to main form
                this.Close();
                
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
            fForm.ShowDialog();

            // MessageBox.Show("Haha you forgot", "lol", MessageBoxButtons.OK);

        }

        private void TitleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(addingPlayerFlag)
            {
                // closes form
                return;
            }
           
            if(!validated && gameBoard != null)
                gameBoard.Close();



            // return new Player(tbUsername.Text);

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            createProfile.ShowDialog();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if(Music.isPlaying)
            {
                Music.Stop();
                muteButton.BackgroundImage = Image.FromFile(Music.OffIcon);
            }
            else
            {
                Music.Resume();
                muteButton.BackgroundImage = Image.FromFile(Music.OnIcon);
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
            this.Close();
        }
    }
}
