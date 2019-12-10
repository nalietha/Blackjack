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
        private Player player = new Player();
        private Dealer houseDealer = new Dealer();
        private Deck deck = new Deck();
        private List<Player> Players = new List<Player>();
        private int currentPlayer = 0;
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
        List<Player> splitpairs;



        public GameBoard(Classes.User user)
        {
            this.username = user._username;
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
                    betUpDown.Maximum = player.PlayerMoney;
                    //Delete file because the player has chosen not to load the save?
                }
            }

            //Start login information
            //set all values
            player.playerNum = 1;
            Players.Add(player);
            playerBalance.Text = "$" + player.PlayerMoney.ToString();
            endTurnButton.Visible = false;
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
        
        /// <summary>
        /// Call this function when a player busts, or when the dealer is done taking cards. Shows the win/lose/tie message.
        /// </summary>
        /// <returns></returns>
        public void CheckForWin()
        {
            saveButton.Enabled = false;
            string msg = "";
            
            foreach (Player player in Players)
            {
                if (houseDealer.CheckBusted() && !player.CheckBusted())
                {
                    msg += "Player " + player.playerNum + " Didn't bust and they won $" + player.currentBet + ".\n\n";
                    player.wins++;
                    player.PlayerMoney += player.currentBet;
                }
                else if (player.CheckBusted())
                {
                    msg += "Player " + player.playerNum + " Busted and they lost $" + player.currentBet + ".\n\n";
                    houseDealer.wins++;
                    player.PlayerMoney -= player.currentBet;
                }
                else if (houseDealer.handValue > player.handValue)
                {
                    msg += "Player " + player.playerNum + " Lost to the dealer and they lost $" + player.currentBet + ".\n\n";
                    houseDealer.wins++;
                    player.PlayerMoney -= player.currentBet;
                }
                else if (houseDealer.handValue < player.handValue)
                {
                    msg += "Player " + player.playerNum + " Has a higher hand than the dealer and they won $" + player.currentBet + ".\n\n"; ;
                    player.wins++;
                    player.PlayerMoney += player.currentBet;
                }
                else
                {
                    msg += "Player " + player.playerNum + " Tied the dealer and kept their bet money.\n\n";
                }
            }
            msg += "Play Again?";
            
            DialogResult result = MessageBox.Show(msg, "Round Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                GetRidOfSplitPairs();
                foreach (Player player in Players)
                {
                    player.done = false;
                    player.currentBet = 10;
                    player.ClearHand();
                }
                currentPlayer = 0;
                ChangePlayer();
                addNewPlayerButton.Visible = true;
                betUpDown.Enabled = true;
                betButton.Enabled = true;
                betUpDown.Maximum = player.PlayerMoney;
                ClearCards(dealerHand);
                ClearCards(playerHand);
            }
            else
                Close();
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
            player.Hit(deck);
            if (Players.Count > 1)
            {
                hitButton.Enabled = false;
            }
            DealCard(playerHand, player.CardList[player.CardList.Count() - 1].imageName);
            playerScore.Text = player.handValue.ToString();

            //Player
            if (player.CheckBusted())
            {
                MessageBox.Show("You Busted", "Busted", MessageBoxButtons.OK);
                player.done = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;
            }

            if(EveryoneDone())
            {
                endTurnButton.Visible = false;
                DealersTurn();
            }
        }

        /// <summary>
        /// Checks if every player has either busted or stayed
        /// </summary>
        /// <returns></returns>
        public bool EveryoneDone()
        {
            bool everyoneDone = true;
            foreach (Player player in Players)
            {
                if (player.done == false)
                    everyoneDone = false;
            }
            return everyoneDone;
        }

        /// <summary>
        /// Changes the "currentplayer" index to the next person that hasn't busted or stayed.
        /// </summary>
        public void FindNextPlayer()
        {

            int nextPlayer = (currentPlayer + 1);
            if (Players.Count == 1 || EveryoneDone())
            {
                currentPlayer = 0;
            }
            else
            {
                if(nextPlayer == Players.Count)
                {
                    nextPlayer = 0;
                }
                while (Players[nextPlayer].done == true)
                {
                    nextPlayer = (nextPlayer + 1) % Players.Count;
                }
                currentPlayer = nextPlayer;
            }
        }

        /// <summary>
    /// Clears everyone's hand, clear the board, payout all bets, and shuffle the deck
    /// </summary>
        public void RestartGame()
        {
            
            if (Players.Count > 1)
                saveButton.Enabled = true;

            //shuffle
            deck.Shuffle();

            //Set everyones hand to empty
            splitpairs = new List<Player>();

            foreach (Player player in Players)
            {
                ClearCards(playerHand);
                player.done = false;
                player.ClearHand();
                player.Hit(deck);
                player.Hit(deck);
                player.aces = false;
             
            }

           /*
            Players[1].CardList[0] = new Card(0);
            Players[1].CardList[1] = new Card(13);
            */

            if (player.CardList.Count == 2 && player.CardList[0].num == player.CardList[1].num)
            {
                DealCard(playerHand, player.CardList[0].imageName);
                DealCard(playerHand, player.CardList[1].imageName);
                DialogResult result = MessageBox.Show("Would you like to split your pairs?", "Split Pairs", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    Player hand2 = new Player();
                    hand2.CardList.Add(player.CardList[0]);
                    hand2.playerNum = player.playerNum;
                    player.CardList.RemoveAt(0);
                    hand2.currentBet = player.currentBet;
                    hand2.originalMoney = (int)player.PlayerMoney;
                    hand2.PlayerMoney = player.PlayerMoney;
                    splitpairs.Add(hand2);
                    Players.Insert(Players.IndexOf(player), hand2);
                    if(player.CardList[0].value == 1)
                    {
                        player.Hit(deck);
                        hand2.Hit(deck);
                        player.aces = true;
                        hand2.aces = true;
                        hitButton.Enabled = false;

                    }
                    player = hand2;
                }
            }

            //clearing the actual hand
            houseDealer.ClearHand();

            //clearing the images
            ClearCards(playerHand);
            ClearCards(dealerHand);

            //labels
            playerScore.Text = "XX";
            dealerScore.Text = "XX";

            //enabling buttons
            if (!player.aces)
                hitButton.Enabled = true;
            stayButton.Enabled = true;
            
            //shuffle
            deck.Shuffle();

            //setting up dealer
            houseDealer.Hit(deck);
            houseDealer.Hit(deck);
            DealCard(dealerHand, houseDealer.CardList[0].imageName);
            HideCard(dealerHand, cardBack);

            //seting up player
            DealCard(playerHand, player.CardList[0].imageName);
            if(player.CardList.Count > 1)
                DealCard(playerHand, player.CardList[1].imageName);
            playerScore.Text = player.handValue.ToString();

            //insurance
            if (houseDealer.CardList[0].value == 1)
            {
                insuranceButton.Visible = true;
                insuranceUpDown.Visible = true;
                insuranceButton.Enabled = true;
                insuranceUpDown.Value = 0;
                insuranceUpDown.Maximum = player.currentBet / 2;
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                MessageBox.Show("Dealer has an ace. You can now place insurance.", "Insurance", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Changes the current player object to the player specified by the currentplayer index variable
        /// </summary>
        public void ChangePlayer()
        {
            //clearing images
            ClearCards(playerHand);
            player = Players[currentPlayer];
            for (int i = 0; i < player.CardList.Count; i++)
                DealCard(playerHand, player.CardList[i].imageName);

            if (player.CardList.Count == 2 && player.CardList[0].num == player.CardList[1].num)
            {
                DialogResult result = MessageBox.Show("Would you like to split your pairs?", "Split Pairs", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Player hand2 = new Player();
                    hand2.CardList.Add(player.CardList[0]);
                    hand2.playerNum = player.playerNum;
                    player.CardList.RemoveAt(0);
                    hand2.currentBet = player.currentBet;
                    hand2.originalMoney = (int)player.PlayerMoney;
                    hand2.PlayerMoney = player.PlayerMoney;
                    splitpairs.Add(hand2);
                    Players.Insert(Players.IndexOf(player), hand2);
                    if (player.CardList[0].value == 1)
                    {
                        player.Hit(deck);
                        hand2.Hit(deck);
                        player.aces = true;
                        hand2.aces = true;

                        hitButton.Enabled = false;

                    }
                    player = hand2;
                }
            }

            //setting players hand
            ClearCards(playerHand);
            for (int i = 0; i < player.CardList.Count; i++)
                DealCard(playerHand, player.CardList[i].imageName);
            player.CalcuateCurrentHand();
            playerScore.Text = player.handValue.ToString();
            wins.Text = player.wins.ToString();
            playerBalance.Text = "$" + player.PlayerMoney;
            playerName.Text = "Player " + player.playerNum;

            //setting the bet
            betUpDown.Value = player.currentBet;
            

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
                player = gamestate.player;

                //condition to do nothing in response to static analysis
                if (player.CardList.Count < 0 || player.CardList.Count > 8)
                    return;
                for (int i = 0; i < player.CardList.Count; i++)
                    DealCard(playerHand, player.CardList[i].imageName);
                player.CalcuateCurrentHand();
                playerScore.Text = player.handValue.ToString();
                wins.Text = player.wins.ToString();

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
                    if(!player.aces)
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
            if(betUpDown.Value > player.PlayerMoney)
                betUpDown.Value = player.PlayerMoney;
            if (betUpDown.Value < betUpDown.Minimum)
                betUpDown.Value = betUpDown.Minimum;
            betUpDown.Value = (int)betUpDown.Value;
        }

        private void insuranceUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (insuranceUpDown.Value > insuranceUpDown.Maximum)
                insuranceUpDown.Value = insuranceUpDown.Maximum;
            if (insuranceUpDown.Value > player.PlayerMoney)
                insuranceUpDown.Value = player.PlayerMoney;
            if (insuranceUpDown.Value < insuranceUpDown.Minimum)
                insuranceUpDown.Value = insuranceUpDown.Minimum;
            insuranceUpDown.Value = (int)insuranceUpDown.Value;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            endTurnButton.Visible = true;
            PlayersTurn();
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            
            endTurnButton.Visible = false;
            hitButton.Enabled = true;
            player.done = true;
            FindNextPlayer();
            ChangePlayer();
            if (EveryoneDone())
            {
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                DealersTurn();
            }
        }

        private void saveButton_Click(object    sender, EventArgs e)
        {
            GameState gameState = new GameState(houseDealer, player, deck, betUpDown.Value, insuranceButton.Visible);
            gameState.SaveGame(SaveFileName, SaveFilePath);
        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            //cool ternary
            player.playerNum = (Players.Count == 0) ? 1 : (Players.Count + 1);
            Players.Add(player);
            saveButton.Visible = false;
            if (Players.Count == 3)
            {
                addNewPlayerButton.Visible = false;
            }
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            endTurnButton.Visible = false;
            stayButton.Enabled = true;
            hitButton.Enabled = true;
            FindNextPlayer();
            ChangePlayer();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            addNewPlayerButton.Visible = false;
            player.currentBet = (int)betUpDown.Value;
            if (currentPlayer < Players.Count - 1)
            {
                betUpDown.Value = 10;
                currentPlayer++;
                ChangePlayer();
            }
            else
            {
                currentPlayer = 0;
                ChangePlayer();
                betUpDown.Enabled = false;
                betButton.Enabled = false;
                RestartGame();
            }
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            player.insurance = (int)insuranceUpDown.Value;
            if (currentPlayer < Players.Count - 1)
            {
                currentPlayer++;
                ChangePlayer();
                insuranceUpDown.Value = 0;
                insuranceUpDown.Maximum = player.currentBet / 2;
            }
            else
            {
                UnhideCard(dealerHand, houseDealer.CardList[1].imageName);
                currentPlayer = 0;
                ChangePlayer();
                insuranceButton.Visible = false;
                insuranceButton.Enabled = false;
                insuranceUpDown.Visible = false;
                if (houseDealer.CardList[1].value == 10)
                {
                    string msg = "";
                    foreach (Player player in Players)
                    {
                        if (player.handValue == 21)
                        {
                            msg += "Player " + player.playerNum + " and the dealer both have Blackjacks. They keep their bet and insurance.\n\n";
                        }
                        else
                        {
                            msg += "House has a Blackjack. Player " + player.playerNum + " loses. Insurance will be paid out to them.\n\n";
                            player.PlayerMoney -= player.currentBet;
                            player.PlayerMoney += 2 * player.insurance;
                            houseDealer.wins++;
                        }
                        
                    }
                    msg += "Play Again?";
                    DialogResult result = MessageBox.Show(msg, "Round Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        foreach (Player player in Players)
                        {
                            player.done = false;
                            player.currentBet = 10;
                            player.insurance = 0;
                            player.ClearHand();
                        }

                        addNewPlayerButton.Visible = true;
                        betUpDown.Enabled = true;
                        betButton.Enabled = true;
                        betUpDown.Maximum = player.PlayerMoney;
                        ClearCards(dealerHand);
                        ClearCards(playerHand);
                        currentPlayer = 0;
                        ChangePlayer();
                    }
                    else
                        Close();
                }
                else
                {
                    if(!player.aces)
                        hitButton.Enabled = true;
                    stayButton.Enabled = true;
                    foreach (Player player in Players)
                    {
                        player.PlayerMoney -= player.insurance;
                    }
                    houseDealer.CalcuateCurrentHand();
                    dealerScore.Text = houseDealer.handValue.ToString();
                    MessageBox.Show("The face down card was not a 10 card. The game will continue as normal.", "No Blackjack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentPlayer = 0;
                    ChangePlayer();
                }
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileInfo profileInfo = new ProfileInfo(player);

            profileInfo.ShowDialog();
            playerBalance.Text = "$" + player.PlayerMoney.ToString();
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

        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFileName != "" && Players.Count == 1)
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

        public void GetRidOfSplitPairs()
        {
            if (splitpairs == null)
                return;
            foreach(Player player in splitpairs)
            {
                int dif = (int) player.PlayerMoney - player.originalMoney;
                Players[Players.IndexOf(player) + 1].PlayerMoney += dif;
                Players.Remove(player);
            }
        }

    }
}

