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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGamesWon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(188, 248);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(170, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Profile";
            // 
            // userMoneyLabel
            // 
            this.userMoneyLabel.AutoSize = true;
            this.userMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.userMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMoneyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userMoneyLabel.Location = new System.Drawing.Point(124, 94);
            this.userMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userMoneyLabel.Name = "userMoneyLabel";
            this.userMoneyLabel.Size = new System.Drawing.Size(40, 24);
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
            this.label2.Location = new System.Drawing.Point(51, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funds:";
            // 
            // DepositMoneyButton
            // 
            this.DepositMoneyButton.Location = new System.Drawing.Point(51, 130);
            this.DepositMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.DepositMoneyButton.Name = "DepositMoneyButton";
            this.DepositMoneyButton.Size = new System.Drawing.Size(68, 21);
            this.DepositMoneyButton.TabIndex = 4;
            this.DepositMoneyButton.Text = "Deposit";
            this.DepositMoneyButton.UseVisualStyleBackColor = true;
            this.DepositMoneyButton.Click += new System.EventHandler(this.depositMoneyButton_Click);
            // 
            // AddMoneyText
            // 
            this.AddMoneyText.Location = new System.Drawing.Point(124, 132);
            this.AddMoneyText.Margin = new System.Windows.Forms.Padding(2);
            this.AddMoneyText.Name = "AddMoneyText";
            this.AddMoneyText.Size = new System.Drawing.Size(76, 20);
            this.AddMoneyText.TabIndex = 5;
            // 
            // WithdrawText
            // 
            this.WithdrawText.Location = new System.Drawing.Point(124, 158);
            this.WithdrawText.Margin = new System.Windows.Forms.Padding(2);
            this.WithdrawText.Name = "WithdrawText";
            this.WithdrawText.Size = new System.Drawing.Size(76, 20);
            this.WithdrawText.TabIndex = 7;
            // 
            // WithdrawMoneyButton
            // 
            this.WithdrawMoneyButton.Location = new System.Drawing.Point(51, 156);
            this.WithdrawMoneyButton.Margin = new System.Windows.Forms.Padding(2);
            this.WithdrawMoneyButton.Name = "WithdrawMoneyButton";
            this.WithdrawMoneyButton.Size = new System.Drawing.Size(68, 21);
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
            this.DepositErrorLabel.Location = new System.Drawing.Point(204, 133);
            this.DepositErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepositErrorLabel.Name = "DepositErrorLabel";
            this.DepositErrorLabel.Size = new System.Drawing.Size(77, 13);
            this.DepositErrorLabel.TabIndex = 8;
            this.DepositErrorLabel.Text = "Invalid Amount";
            this.DepositErrorLabel.Visible = false;
            // 
            // WithdrawErrorLabel
            // 
            this.WithdrawErrorLabel.AutoSize = true;
            this.WithdrawErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawErrorLabel.ForeColor = System.Drawing.Color.White;
            this.WithdrawErrorLabel.Location = new System.Drawing.Point(205, 158);
            this.WithdrawErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WithdrawErrorLabel.Name = "WithdrawErrorLabel";
            this.WithdrawErrorLabel.Size = new System.Drawing.Size(77, 13);
            this.WithdrawErrorLabel.TabIndex = 9;
            this.WithdrawErrorLabel.Text = "Invalid Amount";
            this.WithdrawErrorLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update Payment Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(384, 94);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(21, 20);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "X";
            // 
            // lblGamesWon
            // 
            this.lblGamesWon.AutoSize = true;
            this.lblGamesWon.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesWon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGamesWon.Location = new System.Drawing.Point(384, 156);
            this.lblGamesWon.Name = "lblGamesWon";
            this.lblGamesWon.Size = new System.Drawing.Size(21, 20);
            this.lblGamesWon.TabIndex = 12;
            this.lblGamesWon.Text = "X";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(384, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(21, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "X";
            // 
            // ProfileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 355);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGamesWon);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.button1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfileInfo";
            this.Text = "ProfileInfo";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGamesWon;
        private System.Windows.Forms.Label lblEmail;
    }
}