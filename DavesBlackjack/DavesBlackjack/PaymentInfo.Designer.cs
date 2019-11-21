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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Info";
            // 
            // lblDisplayCardNumber
            // 
            this.lblDisplayCardNumber.AutoSize = true;
            this.lblDisplayCardNumber.Location = new System.Drawing.Point(27, 88);
            this.lblDisplayCardNumber.Name = "lblDisplayCardNumber";
            this.lblDisplayCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblDisplayCardNumber.TabIndex = 1;
            this.lblDisplayCardNumber.Text = "Card Number";
            // 
            // lblDisplayCSC
            // 
            this.lblDisplayCSC.AutoSize = true;
            this.lblDisplayCSC.Location = new System.Drawing.Point(251, 89);
            this.lblDisplayCSC.Name = "lblDisplayCSC";
            this.lblDisplayCSC.Size = new System.Drawing.Size(28, 13);
            this.lblDisplayCSC.TabIndex = 2;
            this.lblDisplayCSC.Text = "CSC";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(27, 137);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(77, 13);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "Name on card:";
            // 
            // lblDisplayBillingAddress
            // 
            this.lblDisplayBillingAddress.AutoSize = true;
            this.lblDisplayBillingAddress.Location = new System.Drawing.Point(27, 187);
            this.lblDisplayBillingAddress.Name = "lblDisplayBillingAddress";
            this.lblDisplayBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.lblDisplayBillingAddress.TabIndex = 4;
            this.lblDisplayBillingAddress.Text = "Billing Address";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(207, 236);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(79, 13);
            this.lblDisplayState.TabIndex = 5;
            this.lblDisplayState.Text = "State/Province";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(27, 236);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(24, 13);
            this.lblDisplayCity.TabIndex = 6;
            this.lblDisplayCity.Text = "City";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(292, 235);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayZipCode.TabIndex = 7;
            this.lblDisplayZipCode.Text = "Zip/Postal Code";
            // 
            // lblDisplayPhoneNumber
            // 
            this.lblDisplayPhoneNumber.AutoSize = true;
            this.lblDisplayPhoneNumber.Location = new System.Drawing.Point(27, 289);
            this.lblDisplayPhoneNumber.Name = "lblDisplayPhoneNumber";
            this.lblDisplayPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblDisplayPhoneNumber.TabIndex = 8;
            this.lblDisplayPhoneNumber.Text = "Phone Number";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(145, 289);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(73, 13);
            this.lblDisplayEmail.TabIndex = 9;
            this.lblDisplayEmail.Text = "Email Address";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(27, 155);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbBillingAddress
            // 
            this.tbBillingAddress.Location = new System.Drawing.Point(27, 206);
            this.tbBillingAddress.Name = "tbBillingAddress";
            this.tbBillingAddress.Size = new System.Drawing.Size(267, 20);
            this.tbBillingAddress.TabIndex = 5;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(27, 254);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(173, 20);
            this.tbCity.TabIndex = 6;
            // 
            // lblDisplayExpireDate
            // 
            this.lblDisplayExpireDate.AutoSize = true;
            this.lblDisplayExpireDate.Location = new System.Drawing.Point(251, 136);
            this.lblDisplayExpireDate.Name = "lblDisplayExpireDate";
            this.lblDisplayExpireDate.Size = new System.Drawing.Size(83, 13);
            this.lblDisplayExpireDate.TabIndex = 19;
            this.lblDisplayExpireDate.Text = "Experation Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(296, 254);
            this.maskedTextBox1.Mask = "00000-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(30, 308);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(254, 107);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox4.TabIndex = 2;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(30, 107);
            this.maskedTextBox5.Mask = "0000 0000 0000 0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBox5.TabIndex = 1;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(254, 155);
            this.maskedTextBox3.Mask = "00/00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBox3.TabIndex = 4;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(210, 254);
            this.maskedTextBox7.Mask = "LL";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox7.TabIndex = 7;
            this.maskedTextBox7.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(259, 351);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplayRequired
            // 
            this.lblDisplayRequired.AutoSize = true;
            this.lblDisplayRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayRequired.Location = new System.Drawing.Point(27, 68);
            this.lblDisplayRequired.Name = "lblDisplayRequired";
            this.lblDisplayRequired.Size = new System.Drawing.Size(71, 13);
            this.lblDisplayRequired.TabIndex = 22;
            this.lblDisplayRequired.Text = "* REQUIRED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(275, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(332, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(375, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(103, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(281, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(52, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(217, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(99, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // pnlEmailError
            // 
            this.pnlEmailError.BackColor = System.Drawing.Color.Red;
            this.pnlEmailError.Location = new System.Drawing.Point(148, 303);
            this.pnlEmailError.Name = "pnlEmailError";
            this.pnlEmailError.Size = new System.Drawing.Size(186, 10);
            this.pnlEmailError.TabIndex = 32;
            // 
            // pnlZipError
            // 
            this.pnlZipError.BackColor = System.Drawing.Color.Red;
            this.pnlZipError.Location = new System.Drawing.Point(296, 249);
            this.pnlZipError.Name = "pnlZipError";
            this.pnlZipError.Size = new System.Drawing.Size(100, 12);
            this.pnlZipError.TabIndex = 33;
            // 
            // pnlStateError
            // 
            this.pnlStateError.BackColor = System.Drawing.Color.Red;
            this.pnlStateError.Location = new System.Drawing.Point(210, 249);
            this.pnlStateError.Name = "pnlStateError";
            this.pnlStateError.Size = new System.Drawing.Size(38, 10);
            this.pnlStateError.TabIndex = 34;
            // 
            // pnlCityError
            // 
            this.pnlCityError.BackColor = System.Drawing.Color.Red;
            this.pnlCityError.Location = new System.Drawing.Point(27, 249);
            this.pnlCityError.Name = "pnlCityError";
            this.pnlCityError.Size = new System.Drawing.Size(173, 12);
            this.pnlCityError.TabIndex = 35;
            // 
            // pnlBillingAddressError
            // 
            this.pnlBillingAddressError.BackColor = System.Drawing.Color.Red;
            this.pnlBillingAddressError.Location = new System.Drawing.Point(27, 202);
            this.pnlBillingAddressError.Name = "pnlBillingAddressError";
            this.pnlBillingAddressError.Size = new System.Drawing.Size(267, 13);
            this.pnlBillingAddressError.TabIndex = 36;
            // 
            // pnlExpeiresError
            // 
            this.pnlExpeiresError.BackColor = System.Drawing.Color.Red;
            this.pnlExpeiresError.Location = new System.Drawing.Point(254, 151);
            this.pnlExpeiresError.Name = "pnlExpeiresError";
            this.pnlExpeiresError.Size = new System.Drawing.Size(37, 10);
            this.pnlExpeiresError.TabIndex = 37;
            // 
            // pnlNameOnCardError
            // 
            this.pnlNameOnCardError.BackColor = System.Drawing.Color.Red;
            this.pnlNameOnCardError.Location = new System.Drawing.Point(27, 150);
            this.pnlNameOnCardError.Name = "pnlNameOnCardError";
            this.pnlNameOnCardError.Size = new System.Drawing.Size(221, 10);
            this.pnlNameOnCardError.TabIndex = 38;
            // 
            // pnlCardNumberError
            // 
            this.pnlCardNumberError.BackColor = System.Drawing.Color.Red;
            this.pnlCardNumberError.Location = new System.Drawing.Point(30, 102);
            this.pnlCardNumberError.Name = "pnlCardNumberError";
            this.pnlCardNumberError.Size = new System.Drawing.Size(218, 23);
            this.pnlCardNumberError.TabIndex = 39;
            // 
            // pnlCSCError
            // 
            this.pnlCSCError.BackColor = System.Drawing.Color.Red;
            this.pnlCSCError.Location = new System.Drawing.Point(254, 102);
            this.pnlCSCError.Name = "pnlCSCError";
            this.pnlCSCError.Size = new System.Drawing.Size(37, 23);
            this.pnlCSCError.TabIndex = 40;
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 450);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
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
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBillingAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblDisplayExpireDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}