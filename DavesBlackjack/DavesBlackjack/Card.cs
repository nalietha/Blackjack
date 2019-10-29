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
        public readonly int id; //Used mainly for card creation
        private int _value; //The value the card has during gameplay
        private string _suit; //The suit of the card
        private string _imageFilePath; // The filepath for the card's image

        public string ImageFilePath { get { return _imageFilePath; } }
        public int Value { get { return _value; } }

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
        

            int parsevalue = ( this.id) % 13 + 1;
            if (parsevalue > 0 && parsevalue <= 10)
            {
               
                this._value = parsevalue;
                if (parsevalue == 1)
                    _imageFilePath = "A";
                else
                    _imageFilePath = parsevalue.ToString();
            }
            else
            {
             
                this._value = 10;
                if(parsevalue == 11)
                    _imageFilePath = "J";
                if (parsevalue == 12)
                    _imageFilePath = "Q";
                if (parsevalue == 13)
                    _imageFilePath = "K";

            }

            int suit = id / 13;
            if (suit == 0)
            {
                this._suit = "Clubs";
                _imageFilePath += "C";
            }
            else if (suit == 1)
            {
                this._suit = "Spades";
                _imageFilePath += "S";
            }
            else if (suit == 2)
            {
                this._suit = "Hearts";
                _imageFilePath += "H";
            }
            else
            {
                this._suit = "Diamonds";
                _imageFilePath += "D";
            }
        }
    }
}
