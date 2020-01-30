namespace DavesBlackjack
{
    partial class ProfileInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileInfo));
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userMoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositMoneyButton = new System.Windows.Forms.Button();
            this.AddMoneyText = new System.Windows.Forms.TextBox();
            this.WithdrawText = new System.Windows.Forms.TextBox();
            this.WithdrawMoneyButton = new System.Windows.Forms.Button();
            this.DepositErrorLabel = new System.Windows.Forms.Label();
            this.WithdrawErrorLabel = new System.Windows.Forms.Label();
            this.updatePaymentInfoButton = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGamesWon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(25, 181);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(197, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Return to Game";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Profile";
            // 
            // userMoneyLabel
            // 
            this.userMoneyLabel.AutoSize = true;
            this.userMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.userMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMoneyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userMoneyLabel.Location = new System.Drawing.Point(122, 75);
            this.userMoneyLabel.Name = "userMoneyLabel";
            this.userMoneyLabel.Size = new System.Drawing.Size(52, 29);
            this.userMoneyLabel.TabIndex = 2;
            this.userMoneyLabel.Text = "$$$";
            this.userMoneyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funds:";
            // 
            // DepositMoneyButton
            // 
            this.DepositMoneyButton.Location = new System.Drawing.Point(25, 119);
            this.DepositMoneyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepositMoneyButton.Name = "DepositMoneyButton";
            this.DepositMoneyButton.Size = new System.Drawing.Size(91, 26);
            this.DepositMoneyButton.TabIndex = 4;
            this.DepositMoneyButton.Text = "Deposit";
            this.DepositMoneyButton.UseVisualStyleBackColor = true;
            this.DepositMoneyButton.Click += new System.EventHandler(this.depositMoneyButton_Click);
            // 
            // AddMoneyText
            // 
            this.AddMoneyText.Location = new System.Drawing.Point(122, 121);
            this.AddMoneyText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMoneyText.Name = "AddMoneyText";
            this.AddMoneyText.Size = new System.Drawing.Size(100, 22);
            this.AddMoneyText.TabIndex = 5;
            // 
            // WithdrawText
            // 
            this.WithdrawText.Location = new System.Drawing.Point(122, 153);
            this.WithdrawText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawText.Name = "WithdrawText";
            this.WithdrawText.Size = new System.Drawing.Size(100, 22);
            this.WithdrawText.TabIndex = 7;
            // 
            // WithdrawMoneyButton
            // 
            this.WithdrawMoneyButton.Location = new System.Drawing.Point(25, 151);
            this.WithdrawMoneyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawMoneyButton.Name = "WithdrawMoneyButton";
            this.WithdrawMoneyButton.Size = new System.Drawing.Size(91, 26);
            this.WithdrawMoneyButton.TabIndex = 6;
            this.WithdrawMoneyButton.Text = "Withdraw";
            this.WithdrawMoneyButton.UseVisualStyleBackColor = true;
            this.WithdrawMoneyButton.Click += new System.EventHandler(this.WithdrawMoneyButton_Click);
            // 
            // DepositErrorLabel
            // 
            this.DepositErrorLabel.AutoSize = true;
            this.DepositErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepositErrorLabel.ForeColor = System.Drawing.Color.White;
            this.DepositErrorLabel.Location = new System.Drawing.Point(229, 123);
            this.DepositErrorLabel.Name = "DepositErrorLabel";
            this.DepositErrorLabel.Size = new System.Drawing.Size(100, 17);
            this.DepositErrorLabel.TabIndex = 8;
            this.DepositErrorLabel.Text = "Invalid Amount";
            this.DepositErrorLabel.Visible = false;
            // 
            // WithdrawErrorLabel
            // 
            this.WithdrawErrorLabel.AutoSize = true;
            this.WithdrawErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawErrorLabel.ForeColor = System.Drawing.Color.White;
            this.WithdrawErrorLabel.Location = new System.Drawing.Point(230, 153);
            this.WithdrawErrorLabel.Name = "WithdrawErrorLabel";
            this.WithdrawErrorLabel.Size = new System.Drawing.Size(100, 17);
            this.WithdrawErrorLabel.TabIndex = 9;
            this.WithdrawErrorLabel.Text = "Invalid Amount";
            this.WithdrawErrorLabel.Visible = false;
            // 
            // updatePaymentInfoButton
            // 
            this.updatePaymentInfoButton.Location = new System.Drawing.Point(25, 216);
            this.updatePaymentInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.updatePaymentInfoButton.Name = "updatePaymentInfoButton";
            this.updatePaymentInfoButton.Size = new System.Drawing.Size(197, 29);
            this.updatePaymentInfoButton.TabIndex = 10;
            this.updatePaymentInfoButton.Text = "Update Payment Info";
            this.updatePaymentInfoButton.UseVisualStyleBackColor = true;
            this.updatePaymentInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(166, 268);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(27, 25);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "X";
            // 
            // lblGamesWon
            // 
            this.lblGamesWon.AutoSize = true;
            this.lblGamesWon.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesWon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGamesWon.Location = new System.Drawing.Point(166, 318);
            this.lblGamesWon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamesWon.Name = "lblGamesWon";
            this.lblGamesWon.Size = new System.Drawing.Size(27, 25);
            this.lblGamesWon.TabIndex = 12;
            this.lblGamesWon.Text = "X";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(166, 293);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(27, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(20, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(20, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Games Won:";
            // 
            // ProfileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.profilebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGamesWon);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.updatePaymentInfoButton);
            this.Controls.Add(this.WithdrawErrorLabel);
            this.Controls.Add(this.DepositErrorLabel);
            this.Controls.Add(this.WithdrawText);
            this.Controls.Add(this.WithdrawMoneyButton);
            this.Controls.Add(this.AddMoneyText);
            this.Controls.Add(this.DepositMoneyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userMoneyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileInfo_FormClosing);
            this.Load += new System.EventHandler(this.ProfileInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userMoneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DepositMoneyButton;
        private System.Windows.Forms.TextBox AddMoneyText;
        private System.Windows.Forms.TextBox WithdrawText;
        private System.Windows.Forms.Button WithdrawMoneyButton;
        private System.Windows.Forms.Label DepositErrorLabel;
        private System.Windows.Forms.Label WithdrawErrorLabel;
        private System.Windows.Forms.Button updatePaymentInfoButton;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGamesWon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}