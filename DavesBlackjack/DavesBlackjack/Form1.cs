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
    public partial class Form1 : Form
    { 
        // Create dealer and player objects
        Dealer houseDealer = new Dealer();
        Player player_01 = new Player();
        Deck deck = new Deck();
        int playerWins = 0;
        int dealerWins = 0;

        List<PictureBox> playerHand = new List<PictureBox>();
        List<PictureBox> dealerHand = new List<PictureBox>();


        public Form1()
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


            //dealers cards
            houseDealer.Hit();
            HideCard(dealerHand, "green_back");
            houseDealer.Hit();
            dealCard(dealerHand, houseDealer.CardList[1].ImageFilePath);

            //players cards
            player_01.Hit();
            dealCard(playerHand, player_01.CardList[0].ImageFilePath);
            player_01.Hit();
            dealCard(playerHand, player_01.CardList[1].ImageFilePath);
            playerScore.Text = player_01.CalcuateCurrentHand().ToString();



        }


        /// <summary>
        /// Function to change the image in the given PictureBox. 
        /// </summary>
        /// <param name="p">Picture box where the image should go</param>
        /// <param name="url">Link of the PNG. This is just the file name with no extention</param>
        public void ChangeCard(PictureBox p, String cardString)
        {
            p.Load("..\\..\\PNG\\"+ cardString + ".png");
            p.BringToFront();
            p.Visible = true;
        }

        /// <summary>
        /// Resets the images in the given deck of cards
        /// </summary>
        /// <param name="pictures">List of Picture Boxes to clear</param>
        public void clearCards(List<PictureBox> pictures)
        {
            int i = 0;
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
            p[0].Load("..\\..\\PNG\\" + cardString + ".png");
            p[0].Visible = true;
        }

        /// <summary>
        /// Unhides the dealers card.
        /// </summary>
        /// <param name="p">Dealers List of Images</param>
        /// <param name="cardString">file location of PNG of the hidden card</param>
        private void UnhideCard(List<PictureBox> p, string cardString)
        {
            p[0].Load("..\\..\\PNG\\" + cardString + ".png");
            p[0].Visible = true;
        }


        /// <summary>
        /// Sets the visuals for drawing a card
        /// </summary>
        /// <param name="p"></param>
        /// <param name="cardString"></param>
        public void dealCard(List<PictureBox> p, string cardString)
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
            

            //DealersTurn();

        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            hitButton.Enabled = false;
            stayButton.Enabled = false;
            DealersTurn();

        }
        /// <summary>
        /// Dealers Turn
        /// </summary>
        /// <returns>Returns message string, if message is not null, dealer loses</returns>
        public string DealersTurn()
        {
            // returns string, hit or stay
            // Display dealers choice
            //lblDealersChoice.Visible = true;

            UnhideCard(dealerHand, houseDealer.CardList[0].ImageFilePath);
            while (houseDealer.Choice())
            {
                dealCard(dealerHand, houseDealer.CardList[houseDealer.CardList.Count() - 1].ImageFilePath);

            }

            dealerScore.Text = houseDealer._handValue.ToString();
            string msg = "";
            


            // Sees who won the game
            if (houseDealer.Busted(houseDealer.CalcuateCurrentHand()) && !player_01.Busted(player_01.CalcuateCurrentHand()))
            {
                msg = "Dealer Busts!\nYOU WIN!\n\nPlay Again?";
                playerWins++;
            }
            else if(!houseDealer.Busted(houseDealer.CalcuateCurrentHand()) && player_01.Busted(player_01.CalcuateCurrentHand()))
            {
                msg = "Player Busts!\nYOU LOSE!\nPlay Again?";
                dealerWins++;
            }
            else if(houseDealer.Busted(houseDealer.CalcuateCurrentHand()) && player_01.Busted(player_01.CalcuateCurrentHand()))
            {
                msg = "Both Bust\nITS A TIE!\nPlay Again?";
            }
            else if(houseDealer.CalcuateCurrentHand() > player_01.CalcuateCurrentHand())
            {
                msg = "Dealer has a higher hand!\nYOU LOSE!\nPlay Again?";
                dealerWins++;
            }
            else if(houseDealer.CalcuateCurrentHand() < player_01.CalcuateCurrentHand())
            {
                msg = "Player has a higher hand!\nYOU WIN!\nPlay Again?";
                playerWins++;
            }
            else
            {
                msg = "Both have the same value!\nITS A TIE!\nPlay Again?";
            }

            wins.Text = playerWins.ToString();
            losses.Text = dealerWins.ToString();
            DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                RestartGame();
            else
                this.Close();
            return msg;
        }
        /// <summary>
        /// The players turn, also checks if the player busts. 
        /// </summary>
        /// <returns></returns>
        public string PlayersTurn()
        {

            player_01.Hit();
            dealCard(playerHand, player_01.CardList[player_01.CardList.Count() - 1].ImageFilePath);
            playerScore.Text = player_01._handValue.ToString();
            string msg = "";
            //Player
            if (player_01.Busted(player_01.CalcuateCurrentHand()))
            {
                //lblDealersChoice.Text = "You busted!\nYOU LOSE!";
                //lblDealersChoice.Visible = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                DealersTurn();
            }
           
            return msg;
        }

        public void RestartGame()
        {
            //clearing the actual hand
            player_01.ClearHand();
            houseDealer.ClearHand();

            //clearing the images
            clearCards(playerHand);
            clearCards(dealerHand);

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
            HideCard(dealerHand, "green_back");
            houseDealer.Hit();
            dealCard(dealerHand, houseDealer.CardList[1].ImageFilePath);

            //players cards
            player_01.Hit();
            dealCard(playerHand, player_01.CardList[0].ImageFilePath);
            player_01.Hit();
            dealCard(playerHand, player_01.CardList[1].ImageFilePath);
            playerScore.Text = player_01.CalcuateCurrentHand().ToString();

        }


    }

   

}

