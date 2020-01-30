namespace DavesBlackjack
{
    partial class PaymentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDisplayCardNumber = new System.Windows.Forms.Label();
            this.lblDisplayCSC = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayBillingAddress = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayPhoneNumber = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBillingAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblDisplayExpireDate = new System.Windows.Forms.Label();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbCSCNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtbExpires = new System.Windows.Forms.MaskedTextBox();
            this.mtbState = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDisplayRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlZipError = new System.Windows.Forms.Panel();
            this.pnlStateError = new System.Windows.Forms.Panel();
            this.pnlCityError = new System.Windows.Forms.Panel();
            this.pnlBillingAddressError = new System.Windows.Forms.Panel();
            this.pnlExpeiresError = new System.Windows.Forms.Panel();
            this.pnlNameOnCardError = new System.Windows.Forms.Panel();
            this.pnlCardNumberError = new System.Windows.Forms.Panel();
            this.pnlCSCError = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.pnlPhoneNumberError = new System.Windows.Forms.Panel();
            this.lblPhoneNumberError = new System.Windows.Forms.Label();
            this.btnQuickFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(17, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Info";
            // 
            // lblDisplayCardNumber
            // 
            this.lblDisplayCardNumber.AutoSize = true;
            this.lblDisplayCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCardNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCardNumber.Location = new System.Drawing.Point(36, 109);
            this.lblDisplayCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayCardNumber.Name = "lblDisplayCardNumber";
            this.lblDisplayCardNumber.Size = new System.Drawing.Size(92, 17);
            this.lblDisplayCardNumber.TabIndex = 1;
            this.lblDisplayCardNumber.Text = "Card Number";
            // 
            // lblDisplayCSC
            // 
            this.lblDisplayCSC.AutoSize = true;
            this.lblDisplayCSC.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCSC.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCSC.Location = new System.Drawing.Point(335, 109);
            this.lblDisplayCSC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayCSC.Name = "lblDisplayCSC";
            this.lblDisplayCSC.Size = new System.Drawing.Size(35, 17);
            this.lblDisplayCSC.TabIndex = 2;
            this.lblDisplayCSC.Text = "CSC";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayName.Location = new System.Drawing.Point(36, 169);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(101, 17);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "Name on card:";
            // 
            // lblDisplayBillingAddress
            // 
            this.lblDisplayBillingAddress.AutoSize = true;
            this.lblDisplayBillingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayBillingAddress.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayBillingAddress.Location = new System.Drawing.Point(36, 230);
            this.lblDisplayBillingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayBillingAddress.Name = "lblDisplayBillingAddress";
            this.lblDisplayBillingAddress.Size = new System.Drawing.Size(101, 17);
            this.lblDisplayBillingAddress.TabIndex = 4;
            this.lblDisplayBillingAddress.Text = "Billing Address";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayState.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayState.Location = new System.Drawing.Point(276, 291);
            this.lblDisplayState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(100, 17);
            this.lblDisplayState.TabIndex = 5;
            this.lblDisplayState.Text = "State/Province";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCity.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCity.Location = new System.Drawing.Point(36, 291);
            this.lblDisplayCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(31, 17);
            this.lblDisplayCity.TabIndex = 6;
            this.lblDisplayCity.Text = "City";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayZipCode.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(390, 289);
            this.lblDisplayZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(108, 17);
            this.lblDisplayZipCode.TabIndex = 7;
            this.lblDisplayZipCode.Text = "Zip/Postal Code";
            // 
            // lblDisplayPhoneNumber
            // 
            this.lblDisplayPhoneNumber.AutoSize = true;
            this.lblDisplayPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayPhoneNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayPhoneNumber.Location = new System.Drawing.Point(36, 355);
            this.lblDisplayPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayPhoneNumber.Name = "lblDisplayPhoneNumber";
            this.lblDisplayPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblDisplayPhoneNumber.TabIndex = 8;
            this.lblDisplayPhoneNumber.Text = "Phone Number";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(36, 191);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(293, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbBillingAddress
            // 
            this.tbBillingAddress.Location = new System.Drawing.Point(36, 253);
            this.tbBillingAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBillingAddress.Name = "tbBillingAddress";
            this.tbBillingAddress.Size = new System.Drawing.Size(355, 22);
            this.tbBillingAddress.TabIndex = 5;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(36, 313);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(229, 22);
            this.tbCity.TabIndex = 6;
            // 
            // lblDisplayExpireDate
            // 
            this.lblDisplayExpireDate.AutoSize = true;
            this.lblDisplayExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayExpireDate.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayExpireDate.Location = new System.Drawing.Point(335, 167);
            this.lblDisplayExpireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayExpireDate.Name = "lblDisplayExpireDate";
            this.lblDisplayExpireDate.Size = new System.Drawing.Size(109, 17);
            this.lblDisplayExpireDate.TabIndex = 19;
            this.lblDisplayExpireDate.Text = "Experation Date";
            // 
            // mtbZip
            // 
            this.mtbZip.Location = new System.Drawing.Point(394, 313);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(132, 22);
            this.mtbZip.TabIndex = 8;
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(40, 379);
            this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbPhoneNumber.Mask = "(999) 000-0000";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.mtbPhoneNumber.TabIndex = 9;
            // 
            // mtbCSCNumber
            // 
            this.mtbCSCNumber.Location = new System.Drawing.Point(338, 131);
            this.mtbCSCNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCSCNumber.Mask = "000";
            this.mtbCSCNumber.Name = "mtbCSCNumber";
            this.mtbCSCNumber.Size = new System.Drawing.Size(50, 22);
            this.mtbCSCNumber.TabIndex = 2;
            this.mtbCSCNumber.ValidatingType = typeof(int);
            // 
            // mtbCardNumber
            // 
            this.mtbCardNumber.Location = new System.Drawing.Point(40, 131);
            this.mtbCardNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbCardNumber.Mask = "0000 0000 0000 0000";
            this.mtbCardNumber.Name = "mtbCardNumber";
            this.mtbCardNumber.Size = new System.Drawing.Size(290, 22);
            this.mtbCardNumber.TabIndex = 1;
            this.mtbCardNumber.ValidatingType = typeof(int);
            // 
            // mtbExpires
            // 
            this.mtbExpires.Location = new System.Drawing.Point(338, 191);
            this.mtbExpires.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbExpires.Mask = "00/00";
            this.mtbExpires.Name = "mtbExpires";
            this.mtbExpires.Size = new System.Drawing.Size(48, 22);
            this.mtbExpires.TabIndex = 4;
            this.mtbExpires.ValidatingType = typeof(System.DateTime);
            // 
            // mtbState
            // 
            this.mtbState.Location = new System.Drawing.Point(280, 313);
            this.mtbState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbState.Mask = "LL";
            this.mtbState.Name = "mtbState";
            this.mtbState.Size = new System.Drawing.Size(50, 22);
            this.mtbState.TabIndex = 7;
            this.mtbState.ValidatingType = typeof(System.DateTime);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(345, 432);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 29);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 432);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplayRequired
            // 
            this.lblDisplayRequired.AutoSize = true;
            this.lblDisplayRequired.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayRequired.Location = new System.Drawing.Point(36, 83);
            this.lblDisplayRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayRequired.Name = "lblDisplayRequired";
            this.lblDisplayRequired.Size = new System.Drawing.Size(89, 17);
            this.lblDisplayRequired.TabIndex = 22;
            this.lblDisplayRequired.Text = "* REQUIRED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(372, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(442, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(500, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(137, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(375, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(70, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(132, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // pnlZipError
            // 
            this.pnlZipError.BackColor = System.Drawing.Color.Red;
            this.pnlZipError.Location = new System.Drawing.Point(394, 307);
            this.pnlZipError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlZipError.Name = "pnlZipError";
            this.pnlZipError.Size = new System.Drawing.Size(134, 15);
            this.pnlZipError.TabIndex = 33;
            this.pnlZipError.Visible = false;
            // 
            // pnlStateError
            // 
            this.pnlStateError.BackColor = System.Drawing.Color.Red;
            this.pnlStateError.Location = new System.Drawing.Point(280, 307);
            this.pnlStateError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlStateError.Name = "pnlStateError";
            this.pnlStateError.Size = new System.Drawing.Size(50, 13);
            this.pnlStateError.TabIndex = 34;
            this.pnlStateError.Visible = false;
            // 
            // pnlCityError
            // 
            this.pnlCityError.BackColor = System.Drawing.Color.Red;
            this.pnlCityError.Location = new System.Drawing.Point(36, 307);
            this.pnlCityError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCityError.Name = "pnlCityError";
            this.pnlCityError.Size = new System.Drawing.Size(231, 15);
            this.pnlCityError.TabIndex = 35;
            this.pnlCityError.Visible = false;
            // 
            // pnlBillingAddressError
            // 
            this.pnlBillingAddressError.BackColor = System.Drawing.Color.Red;
            this.pnlBillingAddressError.Location = new System.Drawing.Point(36, 249);
            this.pnlBillingAddressError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBillingAddressError.Name = "pnlBillingAddressError";
            this.pnlBillingAddressError.Size = new System.Drawing.Size(356, 16);
            this.pnlBillingAddressError.TabIndex = 36;
            this.pnlBillingAddressError.Visible = false;
            // 
            // pnlExpeiresError
            // 
            this.pnlExpeiresError.BackColor = System.Drawing.Color.Red;
            this.pnlExpeiresError.Location = new System.Drawing.Point(338, 186);
            this.pnlExpeiresError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlExpeiresError.Name = "pnlExpeiresError";
            this.pnlExpeiresError.Size = new System.Drawing.Size(49, 13);
            this.pnlExpeiresError.TabIndex = 37;
            this.pnlExpeiresError.Visible = false;
            // 
            // pnlNameOnCardError
            // 
            this.pnlNameOnCardError.BackColor = System.Drawing.Color.Red;
            this.pnlNameOnCardError.Location = new System.Drawing.Point(36, 185);
            this.pnlNameOnCardError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNameOnCardError.Name = "pnlNameOnCardError";
            this.pnlNameOnCardError.Size = new System.Drawing.Size(295, 13);
            this.pnlNameOnCardError.TabIndex = 38;
            this.pnlNameOnCardError.Visible = false;
            // 
            // pnlCardNumberError
            // 
            this.pnlCardNumberError.BackColor = System.Drawing.Color.Red;
            this.pnlCardNumberError.Location = new System.Drawing.Point(40, 125);
            this.pnlCardNumberError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCardNumberError.Name = "pnlCardNumberError";
            this.pnlCardNumberError.Size = new System.Drawing.Size(290, 29);
            this.pnlCardNumberError.TabIndex = 39;
            this.pnlCardNumberError.Visible = false;
            // 
            // pnlCSCError
            // 
            this.pnlCSCError.BackColor = System.Drawing.Color.Red;
            this.pnlCSCError.Location = new System.Drawing.Point(338, 125);
            this.pnlCSCError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCSCError.Name = "pnlCSCError";
            this.pnlCSCError.Size = new System.Drawing.Size(49, 15);
            this.pnlCSCError.TabIndex = 40;
            this.pnlCSCError.Visible = false;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(450, 438);
            this.lblErrors.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(17, 17);
            this.lblErrors.TabIndex = 41;
            this.lblErrors.Text = "X";
            this.lblErrors.Visible = false;
            // 
            // pnlPhoneNumberError
            // 
            this.pnlPhoneNumberError.BackColor = System.Drawing.Color.Red;
            this.pnlPhoneNumberError.Location = new System.Drawing.Point(40, 369);
            this.pnlPhoneNumberError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlPhoneNumberError.Name = "pnlPhoneNumberError";
            this.pnlPhoneNumberError.Size = new System.Drawing.Size(132, 32);
            this.pnlPhoneNumberError.TabIndex = 42;
            this.pnlPhoneNumberError.Visible = false;
            // 
            // lblPhoneNumberError
            // 
            this.lblPhoneNumberError.AutoSize = true;
            this.lblPhoneNumberError.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhoneNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberError.Location = new System.Drawing.Point(180, 382);
            this.lblPhoneNumberError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumberError.Name = "lblPhoneNumberError";
            this.lblPhoneNumberError.Size = new System.Drawing.Size(17, 17);
            this.lblPhoneNumberError.TabIndex = 43;
            this.lblPhoneNumberError.Text = "X";
            this.lblPhoneNumberError.Visible = false;
            // 
            // btnQuickFill
            // 
            this.btnQuickFill.Location = new System.Drawing.Point(131, 432);
            this.btnQuickFill.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnQuickFill.Name = "btnQuickFill";
            this.btnQuickFill.Size = new System.Drawing.Size(97, 29);
            this.btnQuickFill.TabIndex = 44;
            this.btnQuickFill.Text = "QuickFill";
            this.btnQuickFill.UseVisualStyleBackColor = true;
            this.btnQuickFill.Click += new System.EventHandler(this.btnQuickFill_Click);
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.paymentinfobackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 488);
            this.Controls.Add(this.btnQuickFill);
            this.Controls.Add(this.lblPhoneNumberError);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplayRequired);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.mtbState);
            this.Controls.Add(this.mtbCardNumber);
            this.Controls.Add(this.mtbCSCNumber);
            this.Controls.Add(this.mtbExpires);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.mtbZip);
            this.Controls.Add(this.lblDisplayExpireDate);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbBillingAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblDisplayPhoneNumber);
            this.Controls.Add(this.lblDisplayZipCode);
            this.Controls.Add(this.lblDisplayCity);
            this.Controls.Add(this.lblDisplayState);
            this.Controls.Add(this.lblDisplayBillingAddress);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblDisplayCSC);
            this.Controls.Add(this.lblDisplayCardNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlZipError);
            this.Controls.Add(this.pnlStateError);
            this.Controls.Add(this.pnlCityError);
            this.Controls.Add(this.pnlBillingAddressError);
            this.Controls.Add(this.pnlExpeiresError);
            this.Controls.Add(this.pnlNameOnCardError);
            this.Controls.Add(this.pnlCardNumberError);
            this.Controls.Add(this.pnlCSCError);
            this.Controls.Add(this.pnlPhoneNumberError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PaymentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Info";
            this.Load += new System.EventHandler(this.PaymentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDisplayCardNumber;
        private System.Windows.Forms.Label lblDisplayCSC;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblDisplayBillingAddress;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayPhoneNumber;
        private System.Windows.Forms.TextBox tbBillingAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblDisplayExpireDate;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtbCSCNumber;
        private System.Windows.Forms.MaskedTextBox mtbCardNumber;
        private System.Windows.Forms.MaskedTextBox mtbExpires;
        private System.Windows.Forms.MaskedTextBox mtbState;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDisplayRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlZipError;
        private System.Windows.Forms.Panel pnlStateError;
        private System.Windows.Forms.Panel pnlCityError;
        private System.Windows.Forms.Panel pnlBillingAddressError;
        private System.Windows.Forms.Panel pnlExpeiresError;
        private System.Windows.Forms.Panel pnlNameOnCardError;
        private System.Windows.Forms.Panel pnlCardNumberError;
        private System.Windows.Forms.Panel pnlCSCError;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pnlPhoneNumberError;
        private System.Windows.Forms.Label lblPhoneNumberError;
        private System.Windows.Forms.Button btnQuickFill;
    }
}