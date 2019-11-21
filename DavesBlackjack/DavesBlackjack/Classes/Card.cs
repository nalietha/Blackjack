using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    /// <summary>
    /// Contains methods and fields belonging to an individual card
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Used for card creation
        /// </summary>
        public int id;
        /// <summary>
        /// The value of the card when held by a player
        /// </summary>
        public int value { get; private set; }
        /// <summary>
        /// The suit of the card
        /// </summary>
        public string suit { get; private set; }
        /// <summary>
        /// Filename for the image that represents the card
        /// </summary>
        public string imageName { get; private set; }
        public Card(int id)
        {
            this.id = id;
            ParseCardId();
        }

        /// <summary>
        /// Takes the id of the card that called this function, and assigns card information based on the id
        /// </summary>
        private void ParseCardId()
        {
            int parsevalue = id % 13 + 1;
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
    }
}
