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
        List<PictureBox> playerHand = new List<PictureBox>();
        List<PictureBox> dealerHand = new List<PictureBox>();
        Deck deck = new Deck();//deck shared by dealer and player
        Dealer dealer;
        Player player;
        private int playerWins;
        private int dealerWins;


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

            player = new Player(deck);
            dealer = new Dealer(deck);

            playerWins = 0;
            dealerWins = 0;

            SetUpGame();
            // ChangeCard(dealerHand[0], "AD");
            //pTotalString.Text = "Total: 9 hardcode";
            //clearCards(dealerHand);
        }


        /// <summary>
        /// Sets up the Game by
        /// 1.Reseting the images of the cards in the UI
        /// 2.Clearing player's and dealer's hands
        /// 3.Draws the first two Dealer cards
        /// 4.Reseting other UI elements like Labels and Buttons
        /// </summary>
        private void SetUpGame()
        {
            //clear hands
            ClearCards(playerHand);
            ClearCards(dealerHand);

            //reset card lists
            dealer.ResetCards();
            player.ResetCards();

            //draw the first two cards
            dealer.Hit();
            DealCard(dealerHand, dealer.GetCard(dealer.NumOfCards - 1).ImageFilePath);
            dealer.Hit();
            DealCard(dealerHand, dealer.GetCard(dealer.NumOfCards - 1).ImageFilePath);
            HideCard(dealerHand, "green_back");

            //unlocking buttons
            hitButton.Enabled = true;
            stayButton.Enabled = true;

            //Set total labels
            playerScore.Text = "XX";
            dealerScore.Text = "XX";


        }


        /// <summary>
        /// Function to change the image in the given PictureBox. 
        /// </summary>
        /// <param name="p">Picture box where the image should go</param>
        /// <param name="url">Link of the PNG. This is just the file name with no extention</param>
        private void ChangeCard(PictureBox p, String cardString)
        {
            p.Load("..\\..\\PNG\\"+ cardString + ".png");
            p.BringToFront();
            p.Visible = true;
        }

        /// <summary>
        /// Resets the images in the given deck of cards
        /// </summary>
        /// <param name="pictures">List of Picture Boxes to clear</param>
        public void ClearCards(List<PictureBox> pictures)
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
        /// Finishes playing out the dealers hand.
        /// </summary>
        private void RunDealer()
        {
            //unhides the first card
            UnhideCard(dealerHand, dealer.GetCard(0).ImageFilePath);

            //Draws until bust or 17
            while(!dealer.Choice())
            {
                DealCard(dealerHand, dealer.GetCard(dealer.NumOfCards - 1).ImageFilePath);
                dealerScore.Text = dealer.CalcuateCurrentHand().ToString();
                
            }
            dealerScore.Text = dealer.CalcuateCurrentHand().ToString();

            //Who wins
            if (player.Busted() && !dealer.Busted())
            {
                dealerWins++;
            }
            else if(!player.Busted() && dealer.Busted())
            {
                playerWins++;
            }
            else if(player.Busted() && dealer.Busted())
            {
                //No Points
            }
            else if(player.CalcuateCurrentHand() > dealer.CalcuateCurrentHand())
            {
                playerWins++;
            }
            else if(player.CalcuateCurrentHand() < dealer.CalcuateCurrentHand())
            {
                dealerWins++;
            }

            winLabel.Text = playerWins.ToString();
            lossLabel.Text = dealerWins.ToString();
        }

        /// <summary>
        /// Event for clicking the stay button. Disables the stay and hit button and calls a function to run the dealer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stayButton_Click(object sender, EventArgs e)
        {
            stayButton.Enabled = false;
            hitButton.Enabled = false;
            RunDealer();
        }

        /// <summary>
        /// Event for clicking the restart Button. Resets Deck and calls SetUpGame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            SetUpGame();
        }

        /// <summary>
        /// Event for hit button. Calls appropiate function for the player to draw a card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e)
        {
            //get card value
            player.Hit();

            //set UI elements
            DealCard(playerHand, player.GetCard(player.NumOfCards - 1).ImageFilePath);
            playerScore.Text = player.CalcuateCurrentHand().ToString();

            //Check if player busted
            if (player.Busted())
            {
                RunDealer();
                hitButton.Enabled = false;
            }


        }
    }

   

}

