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
            this.lblErrorsExist = new System.Windows.Forms.Label();
            this.pnlQuestionAnswer = new System.Windows.Forms.Panel();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Profile";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 313);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.backButton_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(223, 313);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(111, 27);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(13, 97);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(324, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(13, 140);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(324, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(13, 77);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(13, 122);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(13, 169);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(13, 186);
            this.tbPasswordConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '1';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(324, 20);
            this.tbPasswordConfirm.TabIndex = 8;
            this.tbPasswordConfirm.UseSystemPasswordChar = true;
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
            this.cbSecurityQuestion.Location = new System.Drawing.Point(13, 232);
            this.cbSecurityQuestion.Margin = new System.Windows.Forms.Padding(1);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new System.Drawing.Size(324, 21);
            this.cbSecurityQuestion.TabIndex = 9;
            // 
            // lblSecuirtyQuestionChoice
            // 
            this.lblSecuirtyQuestionChoice.AutoSize = true;
            this.lblSecuirtyQuestionChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblSecuirtyQuestionChoice.ForeColor = System.Drawing.Color.White;
            this.lblSecuirtyQuestionChoice.Location = new System.Drawing.Point(13, 216);
            this.lblSecuirtyQuestionChoice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSecuirtyQuestionChoice.Name = "lblSecuirtyQuestionChoice";
            this.lblSecuirtyQuestionChoice.Size = new System.Drawing.Size(123, 13);
            this.lblSecuirtyQuestionChoice.TabIndex = 10;
            this.lblSecuirtyQuestionChoice.Text = "Select Secuirty Question";
            // 
            // lblSecurityQuestionAnswer
            // 
            this.lblSecurityQuestionAnswer.AutoSize = true;
            this.lblSecurityQuestionAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurityQuestionAnswer.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestionAnswer.Location = new System.Drawing.Point(13, 263);
            this.lblSecurityQuestionAnswer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSecurityQuestionAnswer.Name = "lblSecurityQuestionAnswer";
            this.lblSecurityQuestionAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblSecurityQuestionAnswer.TabIndex = 11;
            this.lblSecurityQuestionAnswer.Text = "Answer:";
            // 
            // tbSecuirtyQuestionAnswer
            // 
            this.tbSecuirtyQuestionAnswer.Location = new System.Drawing.Point(13, 281);
            this.tbSecuirtyQuestionAnswer.Margin = new System.Windows.Forms.Padding(1);
            this.tbSecuirtyQuestionAnswer.Name = "tbSecuirtyQuestionAnswer";
            this.tbSecuirtyQuestionAnswer.Size = new System.Drawing.Size(321, 20);
            this.tbSecuirtyQuestionAnswer.TabIndex = 12;
            this.tbSecuirtyQuestionAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSecuirtyQuestionAnswer_KeyDown);
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameError.ForeColor = System.Drawing.Color.White;
            this.lblUsernameError.Location = new System.Drawing.Point(337, 93);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(14, 13);
            this.lblUsernameError.TabIndex = 13;
            this.lblUsernameError.Text = "X";
            this.lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.ForeColor = System.Drawing.Color.White;
            this.lblPasswordError.Location = new System.Drawing.Point(339, 140);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(14, 13);
            this.lblPasswordError.TabIndex = 14;
            this.lblPasswordError.Text = "X";
            this.lblPasswordError.Visible = false;
            // 
            // lblConfirmError
            // 
            this.lblConfirmError.AutoSize = true;
            this.lblConfirmError.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmError.ForeColor = System.Drawing.Color.White;
            this.lblConfirmError.Location = new System.Drawing.Point(339, 186);
            this.lblConfirmError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblConfirmError.Name = "lblConfirmError";
            this.lblConfirmError.Size = new System.Drawing.Size(14, 13);
            this.lblConfirmError.TabIndex = 15;
            this.lblConfirmError.Text = "X";
            this.lblConfirmError.Visible = false;
            // 
            // lblSecuirtyQuestionError
            // 
            this.lblSecuirtyQuestionError.AutoSize = true;
            this.lblSecuirtyQuestionError.BackColor = System.Drawing.Color.Transparent;
            this.lblSecuirtyQuestionError.ForeColor = System.Drawing.Color.White;
            this.lblSecuirtyQuestionError.Location = new System.Drawing.Point(339, 281);
            this.lblSecuirtyQuestionError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSecuirtyQuestionError.Name = "lblSecuirtyQuestionError";
            this.lblSecuirtyQuestionError.Size = new System.Drawing.Size(14, 13);
            this.lblSecuirtyQuestionError.TabIndex = 16;
            this.lblSecuirtyQuestionError.Text = "X";
            this.lblSecuirtyQuestionError.Visible = false;
            // 
            // lblSelectSecuirtyError
            // 
            this.lblSelectSecuirtyError.AutoSize = true;
            this.lblSelectSecuirtyError.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectSecuirtyError.ForeColor = System.Drawing.Color.White;
            this.lblSelectSecuirtyError.Location = new System.Drawing.Point(337, 233);
            this.lblSelectSecuirtyError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSelectSecuirtyError.Name = "lblSelectSecuirtyError";
            this.lblSelectSecuirtyError.Size = new System.Drawing.Size(14, 13);
            this.lblSelectSecuirtyError.TabIndex = 17;
            this.lblSelectSecuirtyError.Text = "X";
            this.lblSelectSecuirtyError.Visible = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Red;
            this.pnlUsername.Location = new System.Drawing.Point(13, 92);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(1);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(322, 23);
            this.pnlUsername.TabIndex = 18;
            this.pnlUsername.Visible = false;
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
            // pnlQuestionAnswer
            // 
            this.pnlQuestionAnswer.BackColor = System.Drawing.Color.Red;
            this.pnlQuestionAnswer.Location = new System.Drawing.Point(13, 277);
            this.pnlQuestionAnswer.Name = "pnlQuestionAnswer";
            this.pnlQuestionAnswer.Size = new System.Drawing.Size(321, 23);
            this.pnlQuestionAnswer.TabIndex = 20;
            this.pnlQuestionAnswer.Visible = false;
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Red;
            this.pnlConfirmPass.Location = new System.Drawing.Point(13, 182);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(324, 20);
            this.pnlConfirmPass.TabIndex = 21;
            this.pnlConfirmPass.Visible = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Red;
            this.pnlPassword.Location = new System.Drawing.Point(13, 136);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(324, 18);
            this.pnlPassword.TabIndex = 22;
            this.pnlPassword.Visible = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.profilescreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 434);
            this.Controls.Add(this.tbUsername);
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
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.pnlQuestionAnswer);
            this.Controls.Add(this.pnlConfirmPass);
            this.Controls.Add(this.pnlPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblErrorsExist;
        private System.Windows.Forms.Panel pnlQuestionAnswer;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private System.Windows.Forms.Panel pnlPassword;
    }
}