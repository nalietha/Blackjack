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
        private readonly int id; //Used mainly for card creation
        private int value; //The value the card has during gameplay
        private string suit; //The suit of the card
        private string imageFilePath; // The filepath for the card's image

        public Card(int id)
        {
            this.id = id;
            this.ParseCardId();
        }

        /// <summary>
        /// Takes the id of the card that called this function, and assigns card values based on the id
        /// </summary>
        private void ParseCardId()
        {
            int suit = id / 13;
            if(suit == 0)
                this.suit = "Clubs";
            else if( suit == 1)
                this.suit = "Spades";
            else if(suit == 2)
                this.suit = "Hearts";
            else
                this.suit = "Diamonds";

            int parsevalue = ( this.id + 1 ) % 13;
            if (parsevalue > 0 && parsevalue <= 10)
                this.value = parsevalue;
            else
                this.value = 10;
        }
    }
}
