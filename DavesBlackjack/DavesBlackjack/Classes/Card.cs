﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavesBlackjack.Properties;

namespace DavesBlackjack
{
    /// <summary>
    /// Contains methods and fields belonging to an individual card
    /// </summary>
    public class Card
    {
        public int num;
        /// <summary>
        /// Used for card creation
        /// </summary>
        public int id;
        /// <summary>
        /// The value of the card when held by a player
        /// </summary>
        public int value { get; set; }
        /// <summary>
        /// The suit of the card
        /// </summary>
        public string suit { get; set; }
        /// <summary>
        /// Filename for the image that represents the card
        /// </summary>
        public string imageName { get; set; }
        /// <summary>
        /// Card constructor
        /// </summary>
        /// <param name="id">Used to create 1 of 52 (0-51) cards in a deck</param>
        public Card(int id)
        {
            this.id = id;
            ParseCardId();
        }
        /// <summary>
        /// Empty constructor for use with the XMLWriter
        /// </summary>
        public Card()
        {

        }
        /// <summary>
        /// Takes the id of the card that called this function, and assigns card information based on the id
        /// </summary>
        private void ParseCardId()
        {
            int parsevalue = id % 13 + 1;
            num = parsevalue;
            if (parsevalue > 0 && parsevalue <= 10)
            {
                value = parsevalue;
                if (parsevalue == 1)
                    imageName = "A";
                else
                    imageName = parsevalue.ToString();
            }
            else
            {
                value = 10;
                if(parsevalue == 11)
                    imageName = "J";
                if (parsevalue == 12)
                    imageName = "Q";
                if (parsevalue == 13)
                    imageName = "K";
            }

            int suit = id / 13;
            if (suit == 0)
            {
                this.suit = "Clubs";
                imageName += "C";
            }
            else if (suit == 1)
            {
                this.suit = "Spades";
                imageName += "S";
            }
            else if (suit == 2)
            {
                this.suit = "Hearts";
                imageName += "H";
            }
            else
            {
                this.suit = "Diamonds";
                imageName += "D";
            }
        }

        /// <summary>
        /// Used to retrieve the card's image
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Bitmap GetCardImage()
        {
            return Resources.ResourceManager.GetObject(imageName) as System.Drawing.Bitmap;
        }
    }
}
