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
            this.backButton = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblSecuirtyQuestionChoice = new System.Windows.Forms.Label();
            this.lblSecurityQuestionAnswer = new System.Windows.Forms.Label();
            this.tbSecuirtyQuestionAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Profile";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(516, 438);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(184, 66);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(1084, 1135);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(400, 138);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(874, 376);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(856, 38);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(874, 574);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(856, 38);
            this.tbPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(862, 308);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(153, 32);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(874, 500);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(139, 32);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(874, 686);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(245, 32);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(874, 781);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(856, 38);
            this.textBox1.TabIndex = 8;
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
            this.cbSecurityQuestion.Location = new System.Drawing.Point(868, 898);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new System.Drawing.Size(856, 39);
            this.cbSecurityQuestion.TabIndex = 9;
            // 
            // lblSecuirtyQuestionChoice
            // 
            this.lblSecuirtyQuestionChoice.AutoSize = true;
            this.lblSecuirtyQuestionChoice.Location = new System.Drawing.Point(868, 860);
            this.lblSecuirtyQuestionChoice.Name = "lblSecuirtyQuestionChoice";
            this.lblSecuirtyQuestionChoice.Size = new System.Drawing.Size(327, 32);
            this.lblSecuirtyQuestionChoice.TabIndex = 10;
            this.lblSecuirtyQuestionChoice.Text = "Select Secuirty Question";
            // 
            // lblSecurityQuestionAnswer
            // 
            this.lblSecurityQuestionAnswer.AutoSize = true;
            this.lblSecurityQuestionAnswer.Location = new System.Drawing.Point(868, 970);
            this.lblSecurityQuestionAnswer.Name = "lblSecurityQuestionAnswer";
            this.lblSecurityQuestionAnswer.Size = new System.Drawing.Size(109, 32);
            this.lblSecurityQuestionAnswer.TabIndex = 11;
            this.lblSecurityQuestionAnswer.Text = "Answer";
            // 
            // tbSecuirtyQuestionAnswer
            // 
            this.tbSecuirtyQuestionAnswer.Location = new System.Drawing.Point(874, 1015);
            this.tbSecuirtyQuestionAnswer.Name = "tbSecuirtyQuestionAnswer";
            this.tbSecuirtyQuestionAnswer.Size = new System.Drawing.Size(850, 38);
            this.tbSecuirtyQuestionAnswer.TabIndex = 12;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(2844, 1350);
            this.Controls.Add(this.tbSecuirtyQuestionAnswer);
            this.Controls.Add(this.lblSecurityQuestionAnswer);
            this.Controls.Add(this.lblSecuirtyQuestionChoice);
            this.Controls.Add(this.cbSecurityQuestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbSecurityQuestion;
        private System.Windows.Forms.Label lblSecuirtyQuestionChoice;
        private System.Windows.Forms.Label lblSecurityQuestionAnswer;
        private System.Windows.Forms.TextBox tbSecuirtyQuestionAnswer;
    }
}