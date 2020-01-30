using DavesBlackjack.Classes;
using DavesBlackjack.Properties;
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
        /// <summary>
        /// Current player object loaded into the board
        /// </summary>
        private Player player;
        /// <summary>
        /// Dealer object
        /// </summary>
        private Dealer houseDealer = new Dealer();
        /// <summary>
        /// Deck of cards
        /// </summary>
        private readonly Deck deck = new Deck();
        private readonly List<Player> Players = new List<Player>();
        private readonly List<Player> splitpairs = new List<Player>();
        private bool recentlySaved = false;
        private int currentPlayer = 0;
        private Bitmap cardBack;
        string SaveFileName = "";
        readonly string  SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blackjack/Saved Games//";
        readonly List<PictureBox> playerHand = new List<PictureBox>();
        readonly List<PictureBox> dealerHand = new List<PictureBox>();
        public Music Music;

        public GameBoard(string username)
        {
            player = new Player(username);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DavesBlackjack.Forms.ChooseDeck ChooseDeck = new DavesBlackjack.Forms.ChooseDeck();
            Hide();
            ChooseDeck.ShowDialog();
            cardBack = ChooseDeck.cardBack;
            Show();

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

            SaveFileName = player.user.username;
            if (Music.isPlaying)
            {
                muteButton.BackgroundImage = Resources.soundOn;
            }
            else
            {
                muteButton.BackgroundImage = Resources.soundOff;
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
                    //Delete file because the player has chosen not to load the save?
                }
            }

            //Start login information
            //set all values
            player.playerNum = 1;
            Players.Add(player);
            playerBalance.Text = "$" + player.PlayerMoney.ToString();
            wins.Text = player.wins.ToString();
            endTurnButton.Visible = false;
            playerName.Text = player.user.username;
        }

        /// <summary>
        /// Function to change the image in the given PictureBox. 
        /// </summary>
        /// <param name="p">Picture box where the image should go</param>
        /// <param name="url">Link of the PNG. This is just the file name with no extention</param>
        public void ChangeCard(PictureBox p, Bitmap card)
        {
            p.Image = card;
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
        private void HideCard(List<PictureBox> p, Bitmap card)
        {
            p[1].Image = card;
            p[1].Visible = true;
            p[1].BringToFront();
        }

        /// <summary>
        /// Unhides the dealers card.
        /// </summary>
        /// <param name="p">Dealers List of Images</param>
        /// <param name="cardString">file location of PNG of the hidden card</param>
        private void UnhideCard(List<PictureBox> p, Bitmap card)
        {
            p[1].Image = card;
            p[1].Visible = true;
        }

        /// <summary>
        /// Sets the visuals for drawing a card
        /// </summary>
        /// <param name="p"></param>
        /// <param name="cardString"></param>
        public void DealCard(List<PictureBox> p, Bitmap card)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if(p[i].Visible == false)
                {
                    ChangeCard(p[i], card);
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
                    msg += player.user.username + " Didn't bust and they won $" + player.currentBet + ".\n\n";
                    player.wins++;
                    player.PlayerMoney += player.currentBet;
                }
                else if (player.CheckBusted())
                {
                    msg += player.user.username + " Busted and they lost $" + player.currentBet + ".\n\n";
                    player.losses++;
                    player.PlayerMoney -= player.currentBet;
                }
                else if (houseDealer.handValue > player.handValue)
                {
                    msg += player.user.username + " Lost to the dealer and they lost $" + player.currentBet + ".\n\n";
                    player.losses++;
                    player.PlayerMoney -= player.currentBet;
                }
                else if (houseDealer.handValue < player.handValue)
                {
                    msg += player.user.username + " Has a higher hand than the dealer and they won $" + player.currentBet + ".\n\n"; ;
                    player.wins++;
                    player.PlayerMoney += player.currentBet;
                }
                else
                {
                    msg += player.user.username + " Tied the dealer and kept their bet money.\n\n";
                }
            }
            
            MessageBox.Show(msg, "Round Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            logOutButton.Visible = true;
            betUpDown.Enabled = true;
            betButton.Enabled = true;
            ClearCards(dealerHand);
            ClearCards(playerHand);
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
          
            UnhideCard(dealerHand, houseDealer.CardList[1].GetCardImage() as Bitmap);
            while (houseDealer.Choice(deck))
            {
                DealCard(dealerHand, houseDealer.CardList[houseDealer.CardList.Count() - 1].GetCardImage() as Bitmap);
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
            DealCard(playerHand, player.CardList[player.CardList.Count() - 1].GetCardImage() as Bitmap);
            playerScore.Text = player.handValue.ToString();

            if (player.CheckBusted())
            {
                player.done = true;
                endTurnButton.Visible = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;
            }

            if (EveryoneDone())
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
        /// Clears everyone's hand, clear the board, payout all bets
        /// </summary>
        public void RestartGame()
        {
            if (Players.Count == 1)
                saveButton.Enabled = true;

            //Set everyones hand to empty
            splitpairs.Clear();

            foreach (Player player in Players)
            {
                ClearCards(playerHand);
                player.done = false;
                player.ClearHand();
                player.Hit(deck);
                player.Hit(deck);
                player.aces = false;
            }

            if (player.CardList.Count == 2 && player.CardList[0].num == player.CardList[1].num)
            {
                DealCard(playerHand, player.CardList[0].GetCardImage());
                DealCard(playerHand, player.CardList[1].GetCardImage());

                if (player.PlayerMoney < betUpDown.Value * 2)
                    MessageBox.Show("As you cannot afford to match your original bet, you cannot split your pairs. Play will resume as normal.", "Split Pairs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Would you like to split your pairs?", "Split Pairs", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {

                        Player hand2 = new Player
                        {
                            isSplitHand = true
                        };
                        hand2.CardList.Add(player.CardList[0]);
                        hand2.playerNum = player.playerNum;
                        hand2.user = player.user;
                        player.isSplitHand = true;
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

            //setting up dealer
            houseDealer.Hit(deck);
            houseDealer.Hit(deck);
            DealCard(dealerHand, houseDealer.CardList[0].GetCardImage());
            HideCard(dealerHand, cardBack);

            //seting up player
            DealCard(playerHand, player.CardList[0].GetCardImage());
            if(player.CardList.Count > 1)
                DealCard(playerHand, player.CardList[1].GetCardImage());
            playerScore.Text = player.handValue.ToString();

            //insurance
            if (houseDealer.CardList[0].value == 1)
            {
                insuranceButton.Visible = true;
                insuranceUpDown.Visible = true;
                insuranceButton.Enabled = true;
                insuranceUpDown.Value = 0;
                if (player.PlayerMoney >= player.currentBet / 2)
                    insuranceUpDown.Maximum = player.currentBet / 2;
                else
                    insuranceUpDown.Maximum = player.PlayerMoney;
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

            // Get players name
            playerName.Text = player.user.username;

            for (int i = 0; i < player.CardList.Count; i++)
                DealCard(playerHand, player.CardList[i].GetCardImage());

            if (player.CardList.Count == 2 && player.CardList[0].num == player.CardList[1].num)
            {
                DialogResult result = MessageBox.Show("Would you like to split your pairs?", "Split Pairs", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Player hand2 = new Player
                    {
                        isSplitHand = true
                    };
                    hand2.CardList.Add(player.CardList[0]);
                    hand2.playerNum = player.playerNum;
                    hand2.user = player.user;
                    player.CardList.RemoveAt(0);
                    player.isSplitHand = true;
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
                DealCard(playerHand, player.CardList[i].GetCardImage());
            player.CalcuateCurrentHand();
            playerScore.Text = player.handValue.ToString();
            dealerScore.Text = "XX";
            wins.Text = player.wins.ToString();
            losses.Text = player.losses.ToString();
            playerBalance.Text = "$" + player.PlayerMoney;
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
                    DealCard(playerHand, player.CardList[i].GetCardImage());
                player.CalcuateCurrentHand();
                playerScore.Text = player.handValue.ToString();
                wins.Text = player.wins.ToString();

                //setting dealers hand
                houseDealer = gamestate.dealer;
                DealCard(dealerHand, houseDealer.CardList[0].GetCardImage());
                HideCard(dealerHand, cardBack);
                houseDealer.CalcuateCurrentHand();
                losses.Text = player.losses.ToString();

                //setting the deck and bet
                deck.SetDeck(gamestate.deck);
                betUpDown.Value = gamestate.bet;

                //disabling buttons
                betUpDown.Enabled = false;
                betButton.Enabled = false;
                saveButton.Enabled = true;
                recentlySaved = true;

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
                        UnhideCard(dealerHand, houseDealer.CardList[1].GetCardImage());
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
                betUpDown.Value = betUpDown.Minimum;
            if(betUpDown.Value > player.PlayerMoney)
                betUpDown.Value = betUpDown.Minimum;
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
            recentlySaved = false;
            PlayersTurn();
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            recentlySaved = false;
            if (Players.Count > 1)
            {
                endTurnButton.Visible = false;
            }
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
            recentlySaved = true;
            GameState gameState = new GameState(houseDealer, player, deck, betUpDown.Value, insuranceButton.Visible);
            SaveFileName = player.user.username;
            gameState.SaveGame(SaveFileName, SaveFilePath);
            MessageBox.Show("Game successfully saved.", "Game Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            // Used for usercontrol
            //cool ternary
            player.playerNum = (Players.Count == 0) ? 1 : (Players.Count + 1);

            bool unique = true;
            //Player player = new Player();
            //Log in new player

            TitleForm newLogin = new TitleForm(true)
            {
                Music = Music
            };
            this.Hide();
            newLogin.ShowDialog();
            this.Show();

            Player newPlayer = newLogin.AddNewPlayer;
            // If player is null, user exited add form, return to game
            if(newPlayer != null)
            {
                while(unique)
                {
                    if(newPlayer == null)
                    {
                        // Break out
                        return;
                    }

                    unique = false;
                    for( int i = 0; i < Players.Count; i++)
                    {
                        if (Players[i].user.username == newPlayer.user.username)
                            unique = true;
                    }
                    if (unique)
                    {
                        // display login errors, pull up title form again.

                        // clear presesant player info,
                        // 
                        MessageBox.Show("User already logged in, try a different account", "Invalid user");
                        Hide();
                        newLogin.ShowDialog();
                        Show();
                        newPlayer = newLogin.AddNewPlayer;
                    }
                }
                // Player is now unique
                Players.Add(newPlayer);
                saveButton.Visible = false;
                logOutButton.Visible = true;
                if (Players.Count == 3)
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
            if(betUpDown.Value > player.PlayerMoney)
            {
                MessageBox.Show("You can't afford that bet, add more money or choose a smaller bet (Minimum $10).", "Place a valid bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (betUpDown.Value < betUpDown.Minimum)
            {
                MessageBox.Show("You must place a valid bet to participate in the round (Minimum $10).", "Place a valid bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (betUpDown.Value > betUpDown.Maximum)
            {
                //Shouldn't be possible to get here, but you never know.
                MessageBox.Show("You must place a valid bet to participate in the round (Maximum $500).", "Place a valid bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                logOutButton.Visible = false;
                addNewPlayerButton.Visible = false;
                player.currentBet = (int)betUpDown.Value;
                if (currentPlayer < Players.Count - 1)
                {
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
                UnhideCard(dealerHand, houseDealer.CardList[1].GetCardImage());
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
                            msg += player.user.username + " and the dealer both have Blackjacks. They keep their bet and insurance.\n\n";
                        }
                        else
                        {
                            msg += "House has a Blackjack. " + player.user.username + " loses. Insurance will be paid out to them.\n\n";
                            player.PlayerMoney -= player.currentBet;
                            player.PlayerMoney += 2 * player.insurance;
                            player.losses++;
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

                        logOutButton.Visible = true;
                        addNewPlayerButton.Visible = true;
                        betUpDown.Enabled = true;
                        betButton.Enabled = true;
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
            ProfileInfo profileInfo = new ProfileInfo(player, player.user);

            Hide();
            profileInfo.ShowDialog();
            Show();
            playerBalance.Text = "$" + player.PlayerMoney.ToString();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (Music.isPlaying)
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (Players.Count == 1)
            {
                player.LogOutUser();
                Players.Clear();
                TitleForm newLogin = new TitleForm(false)
                {
                    Music = Music
                };
                Hide();
                newLogin.ShowDialog();
                Show();
                if (newLogin.AddNewPlayer == null)
                    Application.Exit();
                else
                    Players.Add(newLogin.AddNewPlayer);

            }
            else
            {
                Forms.LogoutUser logoutUser = new Forms.LogoutUser();
                logoutUser.loggedInUsersListBox.Items.Clear();
                foreach (Player player in Players)
                {
                    logoutUser.loggedInUsersListBox.Items.Add(player.user.username);
                }
                Hide();
                logoutUser.ShowDialog();
                if (logoutUser.DialogResult == DialogResult.OK)
                {
                    foreach (String logOutPlayerString in logoutUser.loggedInUsersListBox.CheckedItems)
                    {
                        Player logOutPlayer = Players.Find(Player => Player.user.username == logOutPlayerString);
                        logOutPlayer.LogOutUser();
                        Players.Remove(logOutPlayer);
                    }
                    if (Players.Count == 0)
                    {
                        TitleForm newLogin = new TitleForm(false)
                        {
                            Music = Music
                        };
                        Hide();
                        newLogin.ShowDialog();
                        Show();
                        Players.Add(newLogin.AddNewPlayer);
                    }
                }
            }
            if (Players.Count == 1)
                saveButton.Visible = true;
            if (Players.Count > 0 )
            {
                addNewPlayerButton.Visible = true;
                logOutButton.Visible = true;
                currentPlayer = 0;
                ChangePlayer();
                Show();
            }
        }

        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFileName != "" && Players.Count == 1 && saveButton.Enabled == true && !recentlySaved)
            {
                DialogResult result = MessageBox.Show("Would you like to save your game?", "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveButton.PerformClick();
                }
            }
            if (Players.Count != 0)
            {
                foreach (Player player in Players)
                {

                    player.LogOutUser();
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
            foreach (Player player in Players)
            {
                if (player.isSplitHand == true)
                    player.isSplitHand = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                Close();
        }
    }
}