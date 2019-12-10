namespace DavesBlackjack
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.muteButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.btnCancelNewPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(268, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Blackjack";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(400, 206);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 33);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Location = new System.Drawing.Point(400, 251);
            this.forgotPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(160, 33);
            this.forgotPasswordButton.TabIndex = 4;
            this.forgotPasswordButton.Text = "Forgot Password";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(381, 113);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(201, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(381, 146);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(201, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(255, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(259, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(400, 295);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(160, 33);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.SystemColors.Control;
            this.lblError.Location = new System.Drawing.Point(412, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(142, 17);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "This is the error label";
            this.lblError.Visible = false;
            // 
            // muteButton
            // 
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("muteButton.BackgroundImage")));
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.muteButton.Location = new System.Drawing.Point(631, 340);
            this.muteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(32, 32);
            this.muteButton.TabIndex = 6;
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Transparent;
            this.skipButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skipButton.BackgroundImage")));
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skipButton.FlatAppearance.BorderSize = 0;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skipButton.Location = new System.Drawing.Point(669, 340);
            this.skipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(32, 32);
            this.skipButton.TabIndex = 7;
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // btnCancelNewPlayer
            // 
            this.btnCancelNewPlayer.Location = new System.Drawing.Point(400, 340);
            this.btnCancelNewPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelNewPlayer.Name = "btnCancelNewPlayer";
            this.btnCancelNewPlayer.Size = new System.Drawing.Size(160, 33);
            this.btnCancelNewPlayer.TabIndex = 8;
            this.btnCancelNewPlayer.Text = "Cancel";
            this.btnCancelNewPlayer.UseVisualStyleBackColor = true;
            this.btnCancelNewPlayer.Visible = false;
            this.btnCancelNewPlayer.Click += new System.EventHandler(this.btnCancelNewPlayer_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.titlescreenbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 384);
            this.Controls.Add(this.btnCancelNewPlayer);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.forgotPasswordButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TitleForm_FormClosing);
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button btnCancelNewPlayer;
    }
}