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
            this.CenterToParent();
        }

        private bool CheckForRequired()
        {
            // Card number
            if(mtbCardNumber.Text == "" || mtbCardNumber.Text.Length > 16)
            {
                // Display errors
            }
            else
            {
                // Remove errors
            }
            // CSC
            if(mtbCSCNumber.Text == "" || mtbCSCNumber.Text.Length > 3)
            {
                // Display errors
            }
            else
            {
                // Remove errors
            }

            // Name
            if (tbName.Text == "")
            {
                // Display errors
            }
            else
            {
                // Remove errors
            }

            // ExpireDate
            if()
            {
                // Display errors
            }
            else
            {
                // Remove errors
            }

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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckForRequired())
            {
                // Do nothing
            }
            else
                AddPaymentInfo();


        }
    }
}
