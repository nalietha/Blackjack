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
    public partial class GameBoard : Form
    { 
        // Create dealer and player objects
        private Dealer houseDealer = new Dealer();
        private Player player_01 = new Player();
        private Deck deck = new Deck();
        string cardLocation = "Resources\\Cards\\";
        string cardBack = "blue_back";
        /// <summary>
        /// The username of the current player, so each player has a different save file.
        /// </summary>
        string SaveFileName = "";
        string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack Saves//";
        List<PictureBox> playerHand = new List<PictureBox>();
        List<PictureBox> dealerHand = new List<PictureBox>();
        Music Music = new Music();

        public GameBoard(Classes.User user)
        {
            this.username = user.username;
            InitializeComponent();

        }
        string username;
        private void Form1_Load(object sender, EventArgs e)
        {
            playerHand.Add(p1);
            playerHand.Add(p2);
            playerHand.Add(p3);
            playerHand.Add(p4);
            playerHand.Add(p5);
            playerHand.Add(p6);
            playerHand.Add(p7);
            playerHand.Add(p8);

            dealerHand.Add(d1);
            dealerHand.Add(d2);
            dealerHand.Add(d3);
            dealerHand.Add(d4);
            dealerHand.Add(d5);
            dealerHand.Add(d6);
            dealerHand.Add(d7);
            dealerHand.Add(d8);

            //TitleForm titleForm = new TitleForm(this, Music);
            //titleForm.ShowDialog();
            SaveFileName = this.username;
            if (Music.isPlaying)
            {
                muteButton.BackgroundImage = Image.FromFile(Music.OnIcon);
            }
            else
            {
                muteButton.BackgroundImage = Image.FromFile(Music.OffIcon);
            }

            if (System.IO.File.Exists(SaveFilePath + SaveFileName + ".xml"))
            {
                DialogResult result = MessageBox.Show("Would you like to load your last save?", "Load Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Read the save file
                    var path = SaveFilePath + SaveFileName + ".xml";
                    Type[] extratypes = new Type[0];
                    System.Xml.Serialization.XmlSerializer reader =
                        new System.Xml.Serialization.XmlSerializer(typeof(GameState), extratypes);
                    System.IO.StreamReader file = new System.IO.StreamReader(@path);

                    GameState gamestate = (GameState)reader.Deserialize(file);
                    SetState(gamestate);
                    file.Close();
                    //Delete File After Loading?
                }
                else
                {
                    betUpDown.Maximum = player_01.PlayerMoney;
                    //Delete file because the player has chosen not to load the save?
                }
            }

            //Start login information
            //set all values
            playerBalance.Text = "$" + player_01.PlayerMoney.ToString();
        }

        /// <summary>
        /// Function to change the image in the given PictureBox. 
        /// </summary>
        /// <param name="p">Picture box where the image should go</param>
        /// <param name="url">Link of the PNG. This is just the file name with no extention</param>
        public void ChangeCard(PictureBox p, String cardString)
        {
            p.Load(cardLocation + cardString + ".png");
            p.BringToFront();
            p.Visible = true;
        }

        /// <summary>
        /// Resets the images in the given deck of cards
        /// </summary>
        /// <param name="pictures">List of Picture Boxes to clear</param>
        public void ClearCards(List<PictureBox> pictures)
        {
            foreach(PictureBox p in pictures)
            {
                p.InitialImage = null;
                p.Visible = false;
            }
        }

        /// <summary>
        /// Hides the dealers first card
        /// </summary>
        /// <param name="p">Dealers List of Images</param>
        /// <param name="cardString">file location of PNG of back of card image</param>
        private void HideCard(List<PictureBox> p, string cardString)
        {
            p[1].Load(cardLocation + cardString + ".png");
            p[1].Visible = true;
            p[1].BringToFront();
        }

        /// <summary>
        /// Unhides the dealers card.
        /// </summary>
        /// <param name="p">Dealers List of Images</param>
        /// <param name="cardString">file location of PNG of the hidden card</param>
        private void UnhideCard(List<PictureBox> p, string cardString)
        {
            p[1].Load(cardLocation + cardString + ".png");
            p[1].Visible = true;
        }

        /// <summary>
        /// Sets the visuals for drawing a card
        /// </summary>
        /// <param name="p"></param>
        /// <param name="cardString"></param>
        public void DealCard(List<PictureBox> p, string cardString)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if(p[i].Visible == false)
                {
                    ChangeCard(p[i], cardString);
                    break;
                }
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            PlayersTurn();
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            
            hitButton.Enabled = false;
            stayButton.Enabled = false;
            DealersTurn();
        }
        
        /// <summary>
        /// Call this function when a player busts, or when the dealer is done taking cards. Shows the win/lose/tie message.
        /// </summary>
        /// <returns></returns>
        public void CheckForWin()
        {
            saveButton.Enabled = false;
            string msg = "";
            // Sees who won the game
            if (houseDealer.CheckBusted() && !player_01.CheckBusted())
            {
                msg = "Dealer Busts!\nYOU WIN!\nPlay Again?";
                player_01.wins++;
                player_01.PlayerMoney += betUpDown.Value;
            }
            else if (player_01.CheckBusted())
            {
                msg = "Player Busts!\nYOU LOSE!\nPlay Again?";
                houseDealer.wins++;
                player_01.PlayerMoney -= betUpDown.Value;
            }
            else if (houseDealer.handValue > player_01.handValue)
            {
                msg = "Dealer has a higher hand!\nYOU LOSE!\nPlay Again?";
                houseDealer.wins++;
                player_01.PlayerMoney -= betUpDown.Value;
            }
            else if (houseDealer.handValue < player_01.handValue)
            {
                msg = "Player has a higher hand!\nYOU WIN!\nPlay Again?";
                player_01.wins++;
                player_01.PlayerMoney += betUpDown.Value;
            }
            else
            {
                msg = "Both have the same value!\nITS A TIE!\nPlay Again?";
            }
            playerBalance.Text = "$" + player_01.PlayerMoney.ToString();
            wins.Text = player_01.wins.ToString();
            losses.Text = houseDealer.wins.ToString();
            DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                betUpDown.Enabled = true;
                betButton.Enabled = true;
                betUpDown.Maximum = player_01.PlayerMoney;
                ClearCards(dealerHand);
                ClearCards(playerHand);
            }
            else
                this.Close();
        }

        /// <summary>
        /// Dealers Turn
        /// </summary>
        /// <returns>Returns message string, if message is not null, dealer loses</returns>
        public void DealersTurn()
        {
            // returns string, hit or stay
            // Display dealers choice
            //lblDealersChoice.Visible = true;
          
            UnhideCard(dealerHand, houseDealer.CardList[1].imageName);
            while (houseDealer.Choice(deck))
            {
                DealCard(dealerHand, houseDealer.CardList[houseDealer.CardList.Count() - 1].imageName);
            }
            dealerScore.Text = houseDealer.handValue.ToString();
            CheckForWin();
        }

        /// <summary>
        /// The players turn, also checks if the player busts. 
        /// </summary>
        /// <returns></returns>
        public void PlayersTurn()
        {
            player_01.Hit(deck);
            DealCard(playerHand, player_01.CardList[player_01.CardList.Count() - 1].imageName);
            playerScore.Text = player_01.handValue.ToString();
            //Player
            if (player_01.CheckBusted())
            {
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                CheckForWin();
            }
        }

        /// <summary>
        /// Clears everyone's hand, clear the board, payout all bets, and shuffle the deck
        /// </summary>
        public void RestartGame()
        {
            saveButton.Enabled = true;
            //clearing the actual hand
            player_01.ClearHand();
            houseDealer.ClearHand();

            //clearing the images
            ClearCards(playerHand);
            ClearCards(dealerHand);

            //labels
            playerScore.Text = "XX";
            dealerScore.Text = "XX";
            //lblDealersChoice.Text = "";

            //enabling buttons
            hitButton.Enabled = true;
            stayButton.Enabled = true;

            //shuffle
            deck.Shuffle();

            //setting up dealer
            houseDealer.Hit(deck);
            houseDealer.Hit(deck);
            //houseDealer.CardList.Add(new Card(13));
            //houseDealer.CardList.Add(new Card(8));
            DealCard(dealerHand, houseDealer.CardList[0].imageName);
            HideCard(dealerHand, cardBack);

            //players cards
            player_01.Hit(deck);
            DealCard(playerHand, player_01.CardList[0].imageName);
            player_01.Hit(deck);
            DealCard(playerHand, player_01.CardList[1].imageName);
            playerScore.Text = player_01.handValue.ToString();



            //insurance
            if(houseDealer.CardList[0].value == 1)
            {
                insuranceButton.Visible = true;
                insuranceUpDown.Visible = true;
                insuranceButton.Enabled = true;
                insuranceUpDown.Value = 0;
                insuranceUpDown.Maximum = betUpDown.Value / 2;
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                MessageBox.Show("Dealer has an ace. You can now place insurance.", "Insurance", MessageBoxButtons.OK);

            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            betUpDown.Enabled = false;
            betButton.Enabled = false;
            RestartGame();
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            UnhideCard(dealerHand, houseDealer.CardList[1].imageName);
            insuranceButton.Visible = false;
            insuranceButton.Enabled = false;
            insuranceUpDown.Visible = false;
            if (houseDealer.CardList[1].value == 10)
            {

                string msg;
                if (player_01.handValue == 21)
                {
                    msg = "Both dealer and player have a blackjack. Stand-off reached. Play again?";
                }
                else
                {
                    msg = "House has a blackjack. Player losses. Insurance will be paid out. Play again?";
                    player_01.PlayerMoney -= betUpDown.Value;
                    player_01.PlayerMoney += 2 * insuranceUpDown.Value;
                    houseDealer.wins++;
                }
                playerBalance.Text = player_01.PlayerMoney.ToString();
                wins.Text = player_01.wins.ToString();
                losses.Text = houseDealer.wins.ToString();
                DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    betUpDown.Enabled = true;
                    betButton.Enabled = true;
                }
                else
                    this.Close();


            }
            else
            {
                hitButton.Enabled = true;
                stayButton.Enabled = true;
               

                player_01.PlayerMoney -= insuranceUpDown.Value;
                playerBalance.Text = player_01.PlayerMoney.ToString();
                houseDealer.CalcuateCurrentHand();
                dealerScore.Text = houseDealer.handValue.ToString();
                MessageBox.Show("The face down card was not a 10 card. The game will continue as normal.", "No Blackjack", MessageBoxButtons.OK);
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileInfo profileInfo = new ProfileInfo(player_01);

            profileInfo.ShowDialog();
            playerBalance.Text = "$" + player_01.PlayerMoney.ToString();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (Music.isPlaying)
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

        /// <summary>
        /// Sets the blackjack game. This should be used when a previous save game is found.
        /// </summary>
        /// <param name="dealerHand">List of Cards for the dealer</param>
        /// <param name="playerHand">List of Cards for the player</param>
        /// <param name="deck">List of Cards for the deck</param>
        /// <param name="bet">The amount bet on the game.(Not insurance)</param>
        /// <param name="beforeInsurance">A boolean value to determine what buttons to disable. Should be true if insurance is in play and the insurance bet hasnt been placed</param>
        public void SetState(GameState gamestate)
        {
            if (gamestate.dealer.CardList.Count > 0 && gamestate.dealer.CardList.Count > 0)
            {
                //clearing images
                ClearCards(playerHand);
                ClearCards(dealerHand);

                //setting players hand
                player_01 = gamestate.player;
                for (int i = 0; i < player_01.CardList.Count; i++)
                    DealCard(playerHand, player_01.CardList[i].imageName);
                player_01.CalcuateCurrentHand();
                playerScore.Text = player_01.handValue.ToString();
                wins.Text = player_01.wins.ToString();

                //setting dealers hand
                houseDealer = gamestate.dealer;
                DealCard(dealerHand, houseDealer.CardList[0].imageName);
                HideCard(dealerHand, cardBack);
                houseDealer.CalcuateCurrentHand();
                losses.Text = houseDealer.wins.ToString();

                //setting the deck and bet
                deck.SetDeck(gamestate.deck);
                betUpDown.Value = gamestate.bet;

                //disabling buttons
                betUpDown.Enabled = false;
                betButton.Enabled = false;


                //calling appropiate next step
                if (gamestate.beforeInsurance)
                {
                    insuranceButton.Visible = true;
                    insuranceUpDown.Visible = true;
                    insuranceButton.Enabled = true;

                    insuranceUpDown.Value = 0;
                    insuranceUpDown.Maximum = betUpDown.Value / 2;
                    hitButton.Enabled = false;
                    stayButton.Enabled = false;
                }
                else
                {
                    insuranceButton.Visible = false;
                    insuranceUpDown.Visible = false;
                    insuranceButton.Enabled = false;
                    if (houseDealer.CardList[0].value == 1)
                        UnhideCard(dealerHand, houseDealer.CardList[1].imageName);
                    hitButton.Enabled = true;
                    stayButton.Enabled = true;
                }
            }
            else
            {
                betButton.Enabled = true;
                playerBalance.Text = gamestate.player.PlayerMoney.ToString();
            }
        }

        private void betUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (betUpDown.Value > betUpDown.Maximum)
                betUpDown.Value = betUpDown.Maximum;
            if(betUpDown.Value > player_01.PlayerMoney)
                betUpDown.Value = player_01.PlayerMoney;
            if (betUpDown.Value < betUpDown.Minimum)
                betUpDown.Value = betUpDown.Minimum;
            betUpDown.Value = (int)betUpDown.Value;
            
        }

        private void insuranceUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (insuranceUpDown.Value > insuranceUpDown.Maximum)
                insuranceUpDown.Value = insuranceUpDown.Maximum;
            if (insuranceUpDown.Value > player_01.PlayerMoney)
                insuranceUpDown.Value = player_01.PlayerMoney;
            if (insuranceUpDown.Value < insuranceUpDown.Minimum)
                insuranceUpDown.Value = insuranceUpDown.Minimum;
            insuranceUpDown.Value = (int)insuranceUpDown.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GameState gameState = new GameState(houseDealer, player_01, deck, betUpDown.Value, insuranceButton.Visible);
            gameState.SaveGame(SaveFileName, SaveFilePath);
        }

        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(SaveFileName != "")
            {
                DialogResult result = MessageBox.Show("Would you like to save your game?", "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveButton.PerformClick();

                }
            }
            
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}

