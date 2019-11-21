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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(201, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Blackjack";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(300, 167);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 27);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Location = new System.Drawing.Point(300, 204);
            this.forgotPasswordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(120, 27);
            this.forgotPasswordButton.TabIndex = 2;
            this.forgotPasswordButton.Text = "Forgot Password";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(286, 92);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(152, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(286, 119);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(152, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(191, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(194, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(300, 240);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(120, 27);
            this.createAccountButton.TabIndex = 7;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.SystemColors.Control;
            this.lblError.Location = new System.Drawing.Point(309, 145);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(104, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "This is the error label";
            this.lblError.Visible = false;
            // 
            // muteButton
            // 
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.soundOff;
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.muteButton.Location = new System.Drawing.Point(473, 276);
            this.muteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(24, 26);
            this.muteButton.TabIndex = 9;
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Transparent;
            this.skipButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.skip;
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skipButton.FlatAppearance.BorderSize = 0;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skipButton.Location = new System.Drawing.Point(502, 276);
            this.skipButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(24, 26);
            this.skipButton.TabIndex = 10;
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.titlescreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 312);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}