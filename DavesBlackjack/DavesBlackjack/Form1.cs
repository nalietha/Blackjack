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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="url"></param>
        public void ChangeCard(PictureBox p, String cardString)
        {
            p.Load(".\\PNG\\"+ cardString + ".png");
            p.BringToFront();
            p.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pictures"></param>
        public void clearCards(List<PictureBox> pictures)
        {
            int i = 0;
            foreach(PictureBox p in pictures)
            {
                
                p.InitialImage = null;
                p.Visible = false;
                  
            }
        }

        public Form1()
        {
            InitializeComponent();

        }


        List<PictureBox> playerHand = new List<PictureBox>();
        List<PictureBox> dealerHand = new List<PictureBox>();
        
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

            ChangeCard(dealerHand[0], "AD");
            pTotalString.Text = "Total: 9 hardcode";
            clearCards(dealerHand);

        }

        public void dealCard(List<PictureBox> p, string cardString)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if(p[i].Visible == false)
                {
                    ChangeCard(p[i], cardString);
                    break;
                }
                Console.WriteLine("nope");
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            PlayersTurn();
            

            DealersTurn();

        }

        private void stayButton_Click(object sender, EventArgs e)
        {
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
            lblDealersChoice.Visible = true;
            lblDealersChoice.Text = houseDealer.Choice();
            dealerScore.Text = houseDealer._handValue.ToString();
            string msg = "";
            
            // Check for game ending on bust
            if (houseDealer.Busted(houseDealer.CalcuateCurrentHand()))
            {
                
                msg = "Dealer Busts!\nYOU WIN!\n\nPlay Again?";

                DialogResult result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    RestartGame();
                // Close game

            }
            return msg;
        }
        /// <summary>
        /// The players turn, also checks if the player busts. 
        /// </summary>
        /// <returns></returns>
        public string PlayersTurn()
        {

            player_01.Hit();
            playerScore.Text = player_01._handValue.ToString();
            string msg = "";
            //Player
            if (player_01.Busted(houseDealer.CalcuateCurrentHand()))
            {
                msg = "You busted!\nYOU LOSE!";
            }
            else if(lblDealersChoice.Text != "Dealer Hits" && player_01._handValue > houseDealer._handValue )
            {


                msg = "Dealer Stayed";
            }
            return msg;
        }

        public void RestartGame()
        {
            player_01.ClearHand();
            houseDealer.ClearHand();

            playerScore.Text = "";
            dealerScore.Text = "";
            lblDealersChoice.Text = "";

        }



    }

   

}

