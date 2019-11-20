namespace DavesBlackjack
{
    partial class CreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.cbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblSecuirtyQuestionChoice = new System.Windows.Forms.Label();
            this.lblSecurityQuestionAnswer = new System.Windows.Forms.Label();
            this.tbSecuirtyQuestionAnswer = new System.Windows.Forms.TextBox();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblConfirmError = new System.Windows.Forms.Label();
            this.lblSecuirtyQuestionError = new System.Windows.Forms.Label();
            this.lblSelectSecuirtyError = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.btnDebugPopulate = new System.Windows.Forms.Button();
            this.lblErrorsExist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Profile";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 746);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 66);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.backButton_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(594, 746);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(295, 64);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(33, 221);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(856, 38);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(33, 329);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(856, 38);
            this.tbPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 177);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(153, 32);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 291);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 32);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(33, 406);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(245, 32);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(33, 444);
            this.tbPasswordConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(856, 38);
            this.tbPasswordConfirm.TabIndex = 8;
            // 
            // cbSecurityQuestion
            // 
            this.cbSecurityQuestion.FormattingEnabled = true;
            this.cbSecurityQuestion.Items.AddRange(new object[] {
            "What was the house number and street name you lived in as a child?",
            "What were the last four digits of your childhood telephone number?",
            "What primary school did you attend?",
            "In what town or city was your first full time job?",
            "In what town or city did you meet your spouse/partner?",
            "What is the middle name of your oldest child?",
            "What are the last five digits of your driver\'s licence number?",
            "What is your grandmother\'s (on your mother\'s side) maiden name?",
            "What is your spouse or partner\'s mother\'s maiden name?",
            "In what town or city did your mother and father meet?"});
            this.cbSecurityQuestion.Location = new System.Drawing.Point(33, 553);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new System.Drawing.Size(856, 39);
            this.cbSecurityQuestion.TabIndex = 9;
            // 
            // lblSecuirtyQuestionChoice
            // 
            this.lblSecuirtyQuestionChoice.AutoSize = true;
            this.lblSecuirtyQuestionChoice.Location = new System.Drawing.Point(33, 515);
            this.lblSecuirtyQuestionChoice.Name = "lblSecuirtyQuestionChoice";
            this.lblSecuirtyQuestionChoice.Size = new System.Drawing.Size(327, 32);
            this.lblSecuirtyQuestionChoice.TabIndex = 10;
            this.lblSecuirtyQuestionChoice.Text = "Select Secuirty Question";
            // 
            // lblSecurityQuestionAnswer
            // 
            this.lblSecurityQuestionAnswer.AutoSize = true;
            this.lblSecurityQuestionAnswer.Location = new System.Drawing.Point(33, 625);
            this.lblSecurityQuestionAnswer.Name = "lblSecurityQuestionAnswer";
            this.lblSecurityQuestionAnswer.Size = new System.Drawing.Size(117, 32);
            this.lblSecurityQuestionAnswer.TabIndex = 11;
            this.lblSecurityQuestionAnswer.Text = "Answer:";
            // 
            // tbSecuirtyQuestionAnswer
            // 
            this.tbSecuirtyQuestionAnswer.Location = new System.Drawing.Point(39, 670);
            this.tbSecuirtyQuestionAnswer.Name = "tbSecuirtyQuestionAnswer";
            this.tbSecuirtyQuestionAnswer.Size = new System.Drawing.Size(850, 38);
            this.tbSecuirtyQuestionAnswer.TabIndex = 12;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Location = new System.Drawing.Point(899, 221);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(34, 32);
            this.lblUsernameError.TabIndex = 13;
            this.lblUsernameError.Text = "X";
            this.lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Location = new System.Drawing.Point(905, 334);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(34, 32);
            this.lblPasswordError.TabIndex = 14;
            this.lblPasswordError.Text = "X";
            this.lblPasswordError.Visible = false;
            // 
            // lblConfirmError
            // 
            this.lblConfirmError.AutoSize = true;
            this.lblConfirmError.Location = new System.Drawing.Point(905, 444);
            this.lblConfirmError.Name = "lblConfirmError";
            this.lblConfirmError.Size = new System.Drawing.Size(34, 32);
            this.lblConfirmError.TabIndex = 15;
            this.lblConfirmError.Text = "X";
            this.lblConfirmError.Visible = false;
            // 
            // lblSecuirtyQuestionError
            // 
            this.lblSecuirtyQuestionError.AutoSize = true;
            this.lblSecuirtyQuestionError.Location = new System.Drawing.Point(905, 670);
            this.lblSecuirtyQuestionError.Name = "lblSecuirtyQuestionError";
            this.lblSecuirtyQuestionError.Size = new System.Drawing.Size(34, 32);
            this.lblSecuirtyQuestionError.TabIndex = 16;
            this.lblSecuirtyQuestionError.Text = "X";
            this.lblSecuirtyQuestionError.Visible = false;
            // 
            // lblSelectSecuirtyError
            // 
            this.lblSelectSecuirtyError.AutoSize = true;
            this.lblSelectSecuirtyError.Location = new System.Drawing.Point(899, 556);
            this.lblSelectSecuirtyError.Name = "lblSelectSecuirtyError";
            this.lblSelectSecuirtyError.Size = new System.Drawing.Size(34, 32);
            this.lblSelectSecuirtyError.TabIndex = 17;
            this.lblSelectSecuirtyError.Text = "X";
            this.lblSelectSecuirtyError.Visible = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.Location = new System.Drawing.Point(33, 212);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(860, 55);
            this.pnlUsername.TabIndex = 18;
            // 
            // btnDebugPopulate
            // 
            this.btnDebugPopulate.Location = new System.Drawing.Point(48, 752);
            this.btnDebugPopulate.Name = "btnDebugPopulate";
            this.btnDebugPopulate.Size = new System.Drawing.Size(295, 54);
            this.btnDebugPopulate.TabIndex = 19;
            this.btnDebugPopulate.Text = "Populate";
            this.btnDebugPopulate.UseVisualStyleBackColor = true;
            // 
            // lblErrorsExist
            // 
            this.lblErrorsExist.AutoSize = true;
            this.lblErrorsExist.Location = new System.Drawing.Point(398, 820);
            this.lblErrorsExist.Name = "lblErrorsExist";
            this.lblErrorsExist.Size = new System.Drawing.Size(34, 32);
            this.lblErrorsExist.TabIndex = 20;
            this.lblErrorsExist.Text = "X";
            this.lblErrorsExist.Visible = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1471, 1036);
            this.Controls.Add(this.lblErrorsExist);
            this.Controls.Add(this.btnDebugPopulate);
            this.Controls.Add(this.lblSelectSecuirtyError);
            this.Controls.Add(this.lblSecuirtyQuestionError);
            this.Controls.Add(this.lblConfirmError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.tbSecuirtyQuestionAnswer);
            this.Controls.Add(this.lblSecurityQuestionAnswer);
            this.Controls.Add(this.lblSecuirtyQuestionChoice);
            this.Controls.Add(this.cbSecurityQuestion);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            this.Load += new System.EventHandler(this.CreateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.ComboBox cbSecurityQuestion;
        private System.Windows.Forms.Label lblSecuirtyQuestionChoice;
        private System.Windows.Forms.Label lblSecurityQuestionAnswer;
        private System.Windows.Forms.TextBox tbSecuirtyQuestionAnswer;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblConfirmError;
        private System.Windows.Forms.Label lblSecuirtyQuestionError;
        private System.Windows.Forms.Label lblSelectSecuirtyError;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Button btnDebugPopulate;
        private System.Windows.Forms.Label lblErrorsExist;
    }
}