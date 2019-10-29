using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class Dealer : Player
    {
        private int[] _dealerhand = { 0 };
        private int currentHand = 0;

        private void Choice()
        {
            // check hand
            if (currentHand > 16)
                Hit();
            else
                Stay();
        }




    }
}
