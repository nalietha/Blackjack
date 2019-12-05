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
        public PaymentInfo(string username)
        {
            this._username = username;
        }

        XDocument doc = XDocument.Load("..\\..\\Database.xml");
        private string _username;

        private void CheckForRequired()
        {
            CardNumberErrors();
            CSCError();
            NameOnCardError();
            BillingAddressError();
            ExperationDateErrors();
            CityErrors();
            StateError();
            ZipErrors();
            PhoneNumberErrors();


            if (CardNumberErrors()
                || CSCError()
                || NameOnCardError()
                || BillingAddressError()
                || ExperationDateErrors()
                || CityErrors()
                || StateError()
                || ZipErrors()
                || PhoneNumberErrors())
            {
                lblErrors.Text = "ERROR: Check Required Infomation";
            }
            else
            {
                // No Errors, add to users data
                AddPaymentInfo();
            }

        }


        // Error Checking Functions
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
                return false;
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
            string locCSC = mtbCSCNumber.Text;
            if (mtbExpires.Text == "")
            {
                // Display errors
                pnlExpeiresError.Visible = true;
                return true;
            }

            else
            {
                // Remove errors
                pnlExpeiresError.Visible = true;
                return false;
            }
            // Add already expired error

        }
        bool BillingAddressError()
        {
            if(tbBillingAddress.Text == "")
            {
                pnlBillingAddressError.Visible = true;
                return true;
            }
            else
            {
                pnlBillingAddressError.Visible = false;
                return false;
            }
        }
        bool CityErrors()
        {
            if (tbCity.Text == "")
            {
                pnlCityError.Visible = true;
                return true;
            }
            else
            {
                pnlCityError.Visible = false;
                return false;
            }
        }
        bool StateError()
        {
            if (mtbState.Text == "")
            {
                pnlStateError.Visible = true;
                return true;
            }
            else
            {
                pnlStateError.Visible = false;
                return false;
            }

        }
        bool ZipErrors()
        {
            if(mtbZip.Text == "")
            {
                pnlZipError.Visible = true;
                return true;
            }
            else
            {
                pnlZipError.Visible = false;
                return false;
            }

        }
        bool PhoneNumberErrors()
        {
            if(mtbPhoneNumber.Text.Length > 10 && mtbPhoneNumber.Text != "")
            {
                pnlPhoneNumberError.Visible = true;
                lblPhoneNumberError.Visible = true;
                lblPhoneNumberError.Text = "Phone Number too short";
                return true;
            }
            pnlPhoneNumberError.Visible = false;
            lblPhoneNumberError.Visible = false;
            return false;
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
            var userAddInfo = doc.Descendants("Username").Where(x => (string)x.Attribute("uName") == _username.ToLower()).FirstOrDefault();

            // Card Info
            userAddInfo.SetElementValue("CardNumber", mtbCardNumber.Text);
            userAddInfo.SetElementValue("NameOnCard", tbName.Text);
            userAddInfo.SetElementValue("SecurityCode", mtbCSCNumber.Text);
            userAddInfo.SetElementValue("ExpireDate", mtbExpires.Text);

            // Location
            userAddInfo.SetElementValue("CardNumber", );
            userAddInfo.SetElementValue("CardNumber", );
            userAddInfo.SetElementValue("CardNumber", );
            userAddInfo.SetElementValue("CardNumber", );

            //XElement UserInfo = doc.Descendants("Username")
            //    .Where(x => (string)x.Attribute("uName") == username)
            //    .Select(x => (string)x.Element("SecurityQuestions")
            //    .Element("Answer")).FirstOrDefault();


        }

    }
}
