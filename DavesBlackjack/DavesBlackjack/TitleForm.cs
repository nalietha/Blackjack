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

        public TitleForm(GameBoard gameBoard)
        {
            InitializeComponent();
            this.gameBoard = gameBoard;
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
    }
}
