using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DavesBlackjack
{
    public partial class PaymentInfo : Form
    {
        public PaymentInfo()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        XDocument doc = XDocument.Load("..\\..\\Database.xml");

        private bool CheckForRequired()
        {
            // Card number
            if(mtbCardNumber.Text == "" || mtbCardNumber.Text.Length > 16)
            {
                // Display errors
                return true;
            }
            else
            {
                // Remove errors
                return false;
            }
            // CSC
            if (mtbCSCNumber.Text == "" || mtbCSCNumber.Text.Length > 3)
            {
                // Display errors
                return true;
            }
            else
            {
                // Remove errors
                return false;
            }

            // Name
            if (tbName.Text == "")
            {
                // Display errors
                return true;
            }
            else
            {
                // Remove errors
                return false;
            }

            // ExpireDate
            if (mtbExpires.Text == "")
            {
                // Display errors
                return true;
            }
            else
            {
                // Remove errors
                return false;
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
        private void AddPaymentInfo()
        {
            // get all payment info
            //XElement UserInfo = doc.Descendants("Username")
            //    .Where(x => (string)x.Attribute("uName") == username)
            //    .Select(x => (string)x.Element("SecurityQuestions")
            //    .Element("Answer")).FirstOrDefault();


        }

    }
}
