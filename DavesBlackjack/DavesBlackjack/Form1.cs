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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="url"></param>
        public void ChangeCard(PictureBox p, String cardString)
        {
            p.Load(".\\PNG\\"+ cardString + ".png");
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

            
            playerTotal.Text = "Total: 9 hardcode";
            clearCards(dealerHand);
        }

        public void dealCard(List<PictureBox> p, string cardString)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if(p[i].InitialImage == null)
                {
                    Console.WriteLine("Hi there");
                }
                Console.WriteLine("nope");
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            dealCard(playerHand, "AS");

        }


        /// <summary>
        /// On player login, call game loop, all visual event handlers should be happening here.
        /// </summary>
        public void gameLoop()
        {





        }

    }

   

}

