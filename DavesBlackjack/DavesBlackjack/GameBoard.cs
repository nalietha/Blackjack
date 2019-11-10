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
        Dealer houseDealer = new Dealer();
        Player player_01 = new Player();
        Deck deck = new Deck();
        int playerWins = 0;
        int dealerWins = 0;
        string cardLocation = "Resources\\Cards\\";
        List<PictureBox> playerHand = new List<PictureBox>();
        List<PictureBox> dealerHand = new List<PictureBox>();

        public GameBoard()
        {
            InitializeComponent();
        }

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

            //Start login information

            //set all values
            playerBalance.Text = player_01.PlayerMoney.ToString();

            TitleForm titleForm = new TitleForm(this);
            titleForm.ShowDialog();
            

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
            string msg = "";
            // Sees who won the game
            if (houseDealer.CheckBusted() && !player_01.CheckBusted())
            {
                msg = "Dealer Busts!\nYOU WIN!\nPlay Again?";
                playerWins++;
                player_01.PlayerMoney += betUpDown.Value;
            }
            else if (player_01.CheckBusted())
            {
                msg = "Player Busts!\nYOU LOSE!\nPlay Again?";
                dealerWins++;
                player_01.PlayerMoney -= betUpDown.Value;
            }
            else if (houseDealer.handValue > player_01.handValue)
            {
                msg = "Dealer has a higher hand!\nYOU LOSE!\nPlay Again?";
                dealerWins++;
                player_01.PlayerMoney -= betUpDown.Value;
            }
            else if (houseDealer.handValue < player_01.handValue)
            {
                msg = "Player has a higher hand!\nYOU WIN!\nPlay Again?";
                playerWins++;
                player_01.PlayerMoney += betUpDown.Value;
            }
            else
            {
                msg = "Both have the same value!\nITS A TIE!\nPlay Again?";
            }
            playerBalance.Text = player_01.PlayerMoney.ToString();
            wins.Text = playerWins.ToString();
            losses.Text = dealerWins.ToString();
            DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                betUpDown.Enabled = true;
                betButton.Enabled = true;
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
            if (dealerHand[1].Visible == false)
                UnhideCard(dealerHand, houseDealer.CardList[0].imageName);
            while (houseDealer.Choice())
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
            player_01.Hit();
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
            Deck.Shuffle();

            //setting up dealer
            houseDealer.Hit();
            houseDealer.Hit();
            //houseDealer.CardList.Add(new Card(13));
            //houseDealer.CardList.Add(new Card(8));
            DealCard(dealerHand, houseDealer.CardList[0].imageName);
            HideCard(dealerHand, "green_back");

            //players cards
            player_01.Hit();
            DealCard(playerHand, player_01.CardList[0].imageName);
            player_01.Hit();
            DealCard(playerHand, player_01.CardList[1].imageName);
            playerScore.Text = player_01.handValue.ToString();

            //insurance
            if(houseDealer.CardList[0].value == 1)
            {
                insuranceButton.Visible = true;
                insuranceUpDown.Visible = true;
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
                    dealerWins++;
                }
                playerBalance.Text = player_01.PlayerMoney.ToString();
                wins.Text = playerWins.ToString();
                losses.Text = dealerWins.ToString();
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
            ProfileInfo profileInfo = new ProfileInfo();
            profileInfo.ShowDialog();
        }
    }
}

