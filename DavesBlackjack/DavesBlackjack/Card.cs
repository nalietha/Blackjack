using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Card
    {
        private int id;
        private string suit;

        public Card(int id)
        {
            this.id = id;
        }


        private void ParseCardValue()
        {
            int suit = id / 13;
            if(suit == 0)
            {
                this.suit = "Clubs";
            }
            else if( suit == 1)
            {
                this.suit = "Spades";
            }
            else if(suit == 2)
            {
                this.suit = "Hearts";
            }
            else
            {
                this.suit = "Diamonds";
            }


    }
}
