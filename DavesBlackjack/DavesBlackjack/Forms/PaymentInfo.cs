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

        //private bool CheckForRequired()
        //{
        //    if(CardNumberErrors()
        //        || CSCError()
        //        || NameOnCardError()
        //        || BillingAddressError()
        //        || ExperationDateErrors()
        //        || CityErrors()
        //        || StateError()
        //        || ZipErrors()
        //        || PhoneNumberErrors())
        //    {
        //        throw new NotImplementedException();

        //    }







        //    // Billing Address

        //    // City

        //    // State

        //    // Zip

        //    // Email
        //}
        bool CardNumberErrors()
        {
            // Card number
            if (mtbCardNumber.Text == "" || mtbCardNumber.Text.Length < 16)
            {
                // Display errors
                pnlCardNumberError.Visible = true;
                return true;
            }
            else
            {
                // Remove errors
                pnlCardNumberError.Visible = false;
                return true;
            }
        }
        bool CSCError()
        {
            // CSC
            if (mtbCSCNumber.Text == "" || mtbCSCNumber.Text.Length > 3)
            {
                // Display errors
                pnlCSCError.Visible = true;
                return true;
            }
            else
            {
                // Remove errors
                pnlCSCError.Visible = false;
                return false;
            }
        }
        bool NameOnCardError()
        {
            // Name
            if (tbName.Text == "")
            {
                // Display errors
                pnlNameOnCardError.Visible = true;
                return true;
            }
            else
            {
                // Remove errors
                pnlNameOnCardError.Visible = false;
                return false;
            }

        }
        bool ExperationDateErrors()
        {
            // ExpireDate
            var currentDate = DateTime.Now;
            if (mtbExpires.Text == "")
            {
                // Display errors
                return true;
            }

            else
            {
                // Remove errors
            }
            string locCSC = mtbCSCNumber.Text;


            return true;

        }
        bool BillingAddressError()
        {
            throw new NotImplementedException();

        }
        bool CityErrors()
        {
            throw new NotImplementedException();

        }
        bool StateError()
        {
            throw new NotImplementedException();

        }
        bool ZipErrors()
        {
            throw new NotImplementedException();

        }
        bool PhoneNumberErrors()
        {
            throw new NotImplementedException();

        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //if (CheckForRequired())
            //{
            //    // Do nothing
            //}
            //else
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
