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
    public partial class PaymentInfo : Form
    {
        public PaymentInfo()
        {
            InitializeComponent();
        }

        private void CheckForRequired()
        {
            // Card number

            // CSC

            // Name

            // ExpireDate

            // Billing Address

            // City

            // State

            // Zip

            // Email


        }






        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
