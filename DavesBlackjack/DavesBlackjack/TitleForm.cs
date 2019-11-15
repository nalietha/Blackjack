using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavesBlackjack
{
    public partial class TitleForm : Form
    {
        
        GameBoard gameBoard;
        private bool validated = false;
        private readonly Music Music;

        public TitleForm(GameBoard gameBoard, Music Music)
        {
            InitializeComponent();
            this.gameBoard = gameBoard;
            this.Music = Music;
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //validate stuff
            validated = true;

            this.Close();
        }
        
        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haha you forgot", "lol", MessageBoxButtons.OK);
        }

        private void TitleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!validated)
                gameBoard.Close();
            
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
    }
}
