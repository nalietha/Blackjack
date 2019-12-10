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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDisplayCardNumber = new System.Windows.Forms.Label();
            this.lblDisplayCSC = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayBillingAddress = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayPhoneNumber = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
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
            this.tbEmail = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEmailError = new System.Windows.Forms.Panel();
            this.pnlZipError = new System.Windows.Forms.Panel();
            this.pnlStateError = new System.Windows.Forms.Panel();
            this.pnlCityError = new System.Windows.Forms.Panel();
            this.pnlBillingAddressError = new System.Windows.Forms.Panel();
            this.pnlExpeiresError = new System.Windows.Forms.Panel();
            this.pnlNameOnCardError = new System.Windows.Forms.Panel();
            this.pnlCardNumberError = new System.Windows.Forms.Panel();
            this.pnlCSCError = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(457, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Info";
            // 
            // lblDisplayCardNumber
            // 
            this.lblDisplayCardNumber.AutoSize = true;
            this.lblDisplayCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCardNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCardNumber.Location = new System.Drawing.Point(50, 163);
            this.lblDisplayCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayCardNumber.Name = "lblDisplayCardNumber";
            this.lblDisplayCardNumber.Size = new System.Drawing.Size(129, 25);
            this.lblDisplayCardNumber.TabIndex = 1;
            this.lblDisplayCardNumber.Text = "Card Number";
            // 
            // lblDisplayCSC
            // 
            this.lblDisplayCSC.AutoSize = true;
            this.lblDisplayCSC.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCSC.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCSC.Location = new System.Drawing.Point(460, 164);
            this.lblDisplayCSC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayCSC.Name = "lblDisplayCSC";
            this.lblDisplayCSC.Size = new System.Drawing.Size(56, 25);
            this.lblDisplayCSC.TabIndex = 2;
            this.lblDisplayCSC.Text = "CSC";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayName.Location = new System.Drawing.Point(50, 253);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(140, 25);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "Name on card:";
            // 
            // lblDisplayBillingAddress
            // 
            this.lblDisplayBillingAddress.AutoSize = true;
            this.lblDisplayBillingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayBillingAddress.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayBillingAddress.Location = new System.Drawing.Point(50, 345);
            this.lblDisplayBillingAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayBillingAddress.Name = "lblDisplayBillingAddress";
            this.lblDisplayBillingAddress.Size = new System.Drawing.Size(141, 25);
            this.lblDisplayBillingAddress.TabIndex = 4;
            this.lblDisplayBillingAddress.Text = "Billing Address";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayState.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayState.Location = new System.Drawing.Point(380, 436);
            this.lblDisplayState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(140, 25);
            this.lblDisplayState.TabIndex = 5;
            this.lblDisplayState.Text = "State/Province";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayCity.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayCity.Location = new System.Drawing.Point(50, 436);
            this.lblDisplayCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(46, 25);
            this.lblDisplayCity.TabIndex = 6;
            this.lblDisplayCity.Text = "City";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayZipCode.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(536, 434);
            this.lblDisplayZipCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(152, 25);
            this.lblDisplayZipCode.TabIndex = 7;
            this.lblDisplayZipCode.Text = "Zip/Postal Code";
            // 
            // lblDisplayPhoneNumber
            // 
            this.lblDisplayPhoneNumber.AutoSize = true;
            this.lblDisplayPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayPhoneNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayPhoneNumber.Location = new System.Drawing.Point(50, 533);
            this.lblDisplayPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayPhoneNumber.Name = "lblDisplayPhoneNumber";
            this.lblDisplayPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblDisplayPhoneNumber.TabIndex = 8;
            this.lblDisplayPhoneNumber.Text = "Phone Number";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayEmail.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayEmail.Location = new System.Drawing.Point(266, 533);
            this.lblDisplayEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(138, 25);
            this.lblDisplayEmail.TabIndex = 9;
            this.lblDisplayEmail.Text = "Email Address";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(50, 286);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(402, 29);
            this.tbName.TabIndex = 3;
            // 
            // tbBillingAddress
            // 
            this.tbBillingAddress.Location = new System.Drawing.Point(50, 380);
            this.tbBillingAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbBillingAddress.Name = "tbBillingAddress";
            this.tbBillingAddress.Size = new System.Drawing.Size(486, 29);
            this.tbBillingAddress.TabIndex = 5;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(50, 469);
            this.tbCity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(314, 29);
            this.tbCity.TabIndex = 6;
            // 
            // lblDisplayExpireDate
            // 
            this.lblDisplayExpireDate.AutoSize = true;
            this.lblDisplayExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayExpireDate.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayExpireDate.Location = new System.Drawing.Point(460, 251);
            this.lblDisplayExpireDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayExpireDate.Name = "lblDisplayExpireDate";
            this.lblDisplayExpireDate.Size = new System.Drawing.Size(151, 25);
            this.lblDisplayExpireDate.TabIndex = 19;
            this.lblDisplayExpireDate.Text = "Experation Date";
            // 
            // mtbZip
            // 
            this.mtbZip.Location = new System.Drawing.Point(542, 469);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(180, 29);
            this.mtbZip.TabIndex = 8;
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(55, 568);
            this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbPhoneNumber.Mask = "(999) 000-0000";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.mtbPhoneNumber.TabIndex = 9;
            // 
            // mtbCSCNumber
            // 
            this.mtbCSCNumber.Location = new System.Drawing.Point(465, 197);
            this.mtbCSCNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbCSCNumber.Mask = "000";
            this.mtbCSCNumber.Name = "mtbCSCNumber";
            this.mtbCSCNumber.Size = new System.Drawing.Size(67, 29);
            this.mtbCSCNumber.TabIndex = 2;
            this.mtbCSCNumber.ValidatingType = typeof(int);
            // 
            // mtbCardNumber
            // 
            this.mtbCardNumber.Location = new System.Drawing.Point(55, 197);
            this.mtbCardNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbCardNumber.Mask = "0000 0000 0000 0000";
            this.mtbCardNumber.Name = "mtbCardNumber";
            this.mtbCardNumber.Size = new System.Drawing.Size(397, 29);
            this.mtbCardNumber.TabIndex = 1;
            this.mtbCardNumber.ValidatingType = typeof(int);
            // 
            // mtbExpires
            // 
            this.mtbExpires.Location = new System.Drawing.Point(465, 286);
            this.mtbExpires.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbExpires.Mask = "00/00";
            this.mtbExpires.Name = "mtbExpires";
            this.mtbExpires.Size = new System.Drawing.Size(64, 29);
            this.mtbExpires.TabIndex = 4;
            this.mtbExpires.ValidatingType = typeof(System.DateTime);
            // 
            // mtbState
            // 
            this.mtbState.Location = new System.Drawing.Point(385, 469);
            this.mtbState.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtbState.Mask = "LL";
            this.mtbState.Name = "mtbState";
            this.mtbState.Size = new System.Drawing.Size(67, 29);
            this.mtbState.TabIndex = 7;
            this.mtbState.ValidatingType = typeof(System.DateTime);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(272, 567);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(337, 29);
            this.tbEmail.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(475, 648);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 43);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 648);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 43);
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
            this.lblDisplayRequired.Location = new System.Drawing.Point(50, 125);
            this.lblDisplayRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayRequired.Name = "lblDisplayRequired";
            this.lblDisplayRequired.Size = new System.Drawing.Size(126, 25);
            this.lblDisplayRequired.TabIndex = 22;
            this.lblDisplayRequired.Text = "* REQUIRED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(512, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(608, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(688, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(189, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(515, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(96, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(398, 533);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(182, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // pnlEmailError
            // 
            this.pnlEmailError.BackColor = System.Drawing.Color.Red;
            this.pnlEmailError.Location = new System.Drawing.Point(272, 560);
            this.pnlEmailError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlEmailError.Name = "pnlEmailError";
            this.pnlEmailError.Size = new System.Drawing.Size(341, 19);
            this.pnlEmailError.TabIndex = 32;
            // 
            // pnlZipError
            // 
            this.pnlZipError.BackColor = System.Drawing.Color.Red;
            this.pnlZipError.Location = new System.Drawing.Point(542, 460);
            this.pnlZipError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlZipError.Name = "pnlZipError";
            this.pnlZipError.Size = new System.Drawing.Size(184, 22);
            this.pnlZipError.TabIndex = 33;
            // 
            // pnlStateError
            // 
            this.pnlStateError.BackColor = System.Drawing.Color.Red;
            this.pnlStateError.Location = new System.Drawing.Point(385, 460);
            this.pnlStateError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlStateError.Name = "pnlStateError";
            this.pnlStateError.Size = new System.Drawing.Size(69, 19);
            this.pnlStateError.TabIndex = 34;
            // 
            // pnlCityError
            // 
            this.pnlCityError.BackColor = System.Drawing.Color.Red;
            this.pnlCityError.Location = new System.Drawing.Point(50, 460);
            this.pnlCityError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlCityError.Name = "pnlCityError";
            this.pnlCityError.Size = new System.Drawing.Size(317, 22);
            this.pnlCityError.TabIndex = 35;
            // 
            // pnlBillingAddressError
            // 
            this.pnlBillingAddressError.BackColor = System.Drawing.Color.Red;
            this.pnlBillingAddressError.Location = new System.Drawing.Point(50, 373);
            this.pnlBillingAddressError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlBillingAddressError.Name = "pnlBillingAddressError";
            this.pnlBillingAddressError.Size = new System.Drawing.Size(490, 24);
            this.pnlBillingAddressError.TabIndex = 36;
            // 
            // pnlExpeiresError
            // 
            this.pnlExpeiresError.BackColor = System.Drawing.Color.Red;
            this.pnlExpeiresError.Location = new System.Drawing.Point(465, 279);
            this.pnlExpeiresError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlExpeiresError.Name = "pnlExpeiresError";
            this.pnlExpeiresError.Size = new System.Drawing.Size(68, 19);
            this.pnlExpeiresError.TabIndex = 37;
            // 
            // pnlNameOnCardError
            // 
            this.pnlNameOnCardError.BackColor = System.Drawing.Color.Red;
            this.pnlNameOnCardError.Location = new System.Drawing.Point(50, 277);
            this.pnlNameOnCardError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlNameOnCardError.Name = "pnlNameOnCardError";
            this.pnlNameOnCardError.Size = new System.Drawing.Size(405, 19);
            this.pnlNameOnCardError.TabIndex = 38;
            // 
            // pnlCardNumberError
            // 
            this.pnlCardNumberError.BackColor = System.Drawing.Color.Red;
            this.pnlCardNumberError.Location = new System.Drawing.Point(55, 188);
            this.pnlCardNumberError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlCardNumberError.Name = "pnlCardNumberError";
            this.pnlCardNumberError.Size = new System.Drawing.Size(399, 43);
            this.pnlCardNumberError.TabIndex = 39;
            // 
            // pnlCSCError
            // 
            this.pnlCSCError.BackColor = System.Drawing.Color.Red;
            this.pnlCSCError.Location = new System.Drawing.Point(465, 188);
            this.pnlCSCError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlCSCError.Name = "pnlCSCError";
            this.pnlCSCError.Size = new System.Drawing.Size(68, 22);
            this.pnlCSCError.TabIndex = 40;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(327, 699);
            this.lblErrors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(26, 25);
            this.lblErrors.TabIndex = 41;
            this.lblErrors.Text = "X";
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.paymentinfoback2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 808);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.tbEmail);
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
            this.Controls.Add(this.lblDisplayEmail);
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
            this.Controls.Add(this.pnlEmailError);
            this.Controls.Add(this.pnlStateError);
            this.Controls.Add(this.pnlCityError);
            this.Controls.Add(this.pnlBillingAddressError);
            this.Controls.Add(this.pnlExpeiresError);
            this.Controls.Add(this.pnlNameOnCardError);
            this.Controls.Add(this.pnlCardNumberError);
            this.Controls.Add(this.pnlCSCError);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PaymentInfo";
            this.Text = "PaymentInfo";
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
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.TextBox tbBillingAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblDisplayExpireDate;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtbCSCNumber;
        private System.Windows.Forms.MaskedTextBox mtbCardNumber;
        private System.Windows.Forms.MaskedTextBox mtbExpires;
        private System.Windows.Forms.MaskedTextBox mtbState;
        private System.Windows.Forms.TextBox tbEmail;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlEmailError;
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
    }
}