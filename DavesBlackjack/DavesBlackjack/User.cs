using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesBlackjack
{
    class User
    {
        public User()
        {
            
        }

        public string _username;

        public string GetUsername()
        {

            return this._username;
        }

        public decimal GetUserMoney()
        {
            // Parse XML file with username to find amount of cash the the user has left


            return (decimal)1000.00;
        }

        public bool ChangeUserPassword()
        {
            // Ask for current password

            // if unknown ask them for their security question.
            return false;
        }


    }
}
