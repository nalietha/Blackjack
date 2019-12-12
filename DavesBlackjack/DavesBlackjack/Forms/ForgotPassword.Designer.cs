namespace DavesBlackjack
{
    partial class ForgotPassword
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.tbUsernameRecovery = new System.Windows.Forms.TextBox();
            this.lblDisplaySecurityQuestion = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbSQAnswer = new System.Windows.Forms.TextBox();
            this.btnSQEnter = new System.Windows.Forms.Button();
            this.lblDisplayChangePass = new System.Windows.Forms.Label();
            this.pnlSecQuestions = new System.Windows.Forms.Panel();
            this.lblSQError = new System.Windows.Forms.Label();
            this.pnlSecurityQuestionError = new System.Windows.Forms.Panel();
            this.pnlPasswordDisplay = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmPassShow = new System.Windows.Forms.Button();
            this.btnNewPassShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfimPass = new System.Windows.Forms.TextBox();
            this.pnlConfirmPassError = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.pnlChangePasswordError = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblUserErrorDisplay = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlSecQuestions.SuspendLayout();
            this.pnlPasswordDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(17, 16);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(289, 39);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Forgot Password";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDisplayUsername.Location = new System.Drawing.Point(25, 59);
            this.lblDisplayUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(77, 17);
            this.lblDisplayUsername.TabIndex = 1;
            this.lblDisplayUsername.Text = "Username:";
            // 
            // tbUsernameRecovery
            // 
            this.tbUsernameRecovery.Location = new System.Drawing.Point(29, 80);
            this.tbUsernameRecovery.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsernameRecovery.Name = "tbUsernameRecovery";
            this.tbUsernameRecovery.Size = new System.Drawing.Size(300, 22);
            this.tbUsernameRecovery.TabIndex = 1;
            this.tbUsernameRecovery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsernameRecovery_KeyDown);
            // 
            // lblDisplaySecurityQuestion
            // 
            this.lblDisplaySecurityQuestion.AutoSize = true;
            this.lblDisplaySecurityQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplaySecurityQuestion.Location = new System.Drawing.Point(13, 6);
            this.lblDisplaySecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplaySecurityQuestion.Name = "lblDisplaySecurityQuestion";
            this.lblDisplaySecurityQuestion.Size = new System.Drawing.Size(170, 17);
            this.lblDisplaySecurityQuestion.TabIndex = 3;
            this.lblDisplaySecurityQuestion.Text = "Answer Security Question";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(13, 22);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(37, 17);
            this.lblSecurityQuestion.TabIndex = 4;
            this.lblSecurityQuestion.Text = "Hide";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(343, 75);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 27);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbSQAnswer
            // 
            this.tbSQAnswer.Location = new System.Drawing.Point(12, 50);
            this.tbSQAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSQAnswer.Name = "tbSQAnswer";
            this.tbSQAnswer.Size = new System.Drawing.Size(302, 22);
            this.tbSQAnswer.TabIndex = 3;
            this.tbSQAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnSQEnter
            // 
            this.btnSQEnter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSQEnter.Location = new System.Drawing.Point(327, 43);
            this.btnSQEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnSQEnter.Name = "btnSQEnter";
            this.btnSQEnter.Size = new System.Drawing.Size(100, 29);
            this.btnSQEnter.TabIndex = 4;
            this.btnSQEnter.Text = "Enter";
            this.btnSQEnter.UseVisualStyleBackColor = true;
            this.btnSQEnter.Click += new System.EventHandler(this.btnSQEnter_Click);
            // 
            // lblDisplayChangePass
            // 
            this.lblDisplayChangePass.AutoSize = true;
            this.lblDisplayChangePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplayChangePass.Location = new System.Drawing.Point(13, 9);
            this.lblDisplayChangePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayChangePass.Name = "lblDisplayChangePass";
            this.lblDisplayChangePass.Size = new System.Drawing.Size(122, 17);
            this.lblDisplayChangePass.TabIndex = 8;
            this.lblDisplayChangePass.Text = "Change Password";
            // 
            // pnlSecQuestions
            // 
            this.pnlSecQuestions.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecQuestions.Controls.Add(this.lblSQError);
            this.pnlSecQuestions.Controls.Add(this.tbSQAnswer);
            this.pnlSecQuestions.Controls.Add(this.lblDisplaySecurityQuestion);
            this.pnlSecQuestions.Controls.Add(this.lblSecurityQuestion);
            this.pnlSecQuestions.Controls.Add(this.btnSQEnter);
            this.pnlSecQuestions.Controls.Add(this.pnlSecurityQuestionError);
            this.pnlSecQuestions.ForeColor = System.Drawing.SystemColors.Info;
            this.pnlSecQuestions.Location = new System.Drawing.Point(16, 113);
            this.pnlSecQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSecQuestions.Name = "pnlSecQuestions";
            this.pnlSecQuestions.Size = new System.Drawing.Size(512, 85);
            this.pnlSecQuestions.TabIndex = 10;
            this.pnlSecQuestions.Visible = false;
            // 
            // lblSQError
            // 
            this.lblSQError.AutoSize = true;
            this.lblSQError.BackColor = System.Drawing.Color.Red;
            this.lblSQError.ForeColor = System.Drawing.Color.Black;
            this.lblSQError.Location = new System.Drawing.Point(430, 49);
            this.lblSQError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSQError.Name = "lblSQError";
            this.lblSQError.Size = new System.Drawing.Size(50, 17);
            this.lblSQError.TabIndex = 16;
            this.lblSQError.Text = "Wrong";
            this.lblSQError.Visible = false;
            // 
            // pnlSecurityQuestionError
            // 
            this.pnlSecurityQuestionError.BackColor = System.Drawing.Color.Red;
            this.pnlSecurityQuestionError.Location = new System.Drawing.Point(12, 43);
            this.pnlSecurityQuestionError.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSecurityQuestionError.Name = "pnlSecurityQuestionError";
            this.pnlSecurityQuestionError.Size = new System.Drawing.Size(301, 15);
            this.pnlSecurityQuestionError.TabIndex = 14;
            this.pnlSecurityQuestionError.Visible = false;
            // 
            // pnlPasswordDisplay
            // 
            this.pnlPasswordDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordDisplay.Controls.Add(this.btnCancel);
            this.pnlPasswordDisplay.Controls.Add(this.tbNewPassword);
            this.pnlPasswordDisplay.Controls.Add(this.btnConfirmPassShow);
            this.pnlPasswordDisplay.Controls.Add(this.btnNewPassShow);
            this.pnlPasswordDisplay.Controls.Add(this.label2);
            this.pnlPasswordDisplay.Controls.Add(this.tbConfimPass);
            this.pnlPasswordDisplay.Controls.Add(this.pnlConfirmPassError);
            this.pnlPasswordDisplay.Controls.Add(this.btnChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.lblDisplayChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.pnlChangePasswordError);
            this.pnlPasswordDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.pnlPasswordDisplay.Location = new System.Drawing.Point(16, 206);
            this.pnlPasswordDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPasswordDisplay.Name = "pnlPasswordDisplay";
            this.pnlPasswordDisplay.Size = new System.Drawing.Size(512, 142);
            this.pnlPasswordDisplay.TabIndex = 11;
            this.pnlPasswordDisplay.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(327, 93);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(13, 35);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(301, 22);
            this.tbNewPassword.TabIndex = 5;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // btnConfirmPassShow
            // 
            this.btnConfirmPassShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmPassShow.Location = new System.Drawing.Point(433, 92);
            this.btnConfirmPassShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPassShow.Name = "btnConfirmPassShow";
            this.btnConfirmPassShow.Size = new System.Drawing.Size(63, 29);
            this.btnConfirmPassShow.TabIndex = 10;
            this.btnConfirmPassShow.Text = "Show";
            this.btnConfirmPassShow.UseVisualStyleBackColor = true;
            this.btnConfirmPassShow.Click += new System.EventHandler(this.btnConfirmPassShow_Click);
            // 
            // btnNewPassShow
            // 
            this.btnNewPassShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewPassShow.Location = new System.Drawing.Point(434, 29);
            this.btnNewPassShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPassShow.Name = "btnNewPassShow";
            this.btnNewPassShow.Size = new System.Drawing.Size(62, 28);
            this.btnNewPassShow.TabIndex = 7;
            this.btnNewPassShow.Text = "Show";
            this.btnNewPassShow.UseVisualStyleBackColor = true;
            this.btnNewPassShow.Click += new System.EventHandler(this.btnNewPassShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confim Password";
            // 
            // tbConfimPass
            // 
            this.tbConfimPass.Location = new System.Drawing.Point(13, 103);
            this.tbConfimPass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbConfimPass.Name = "tbConfimPass";
            this.tbConfimPass.Size = new System.Drawing.Size(300, 22);
            this.tbConfimPass.TabIndex = 8;
            this.tbConfimPass.UseSystemPasswordChar = true;
            // 
            // pnlConfirmPassError
            // 
            this.pnlConfirmPassError.BackColor = System.Drawing.Color.Red;
            this.pnlConfirmPassError.Location = new System.Drawing.Point(13, 97);
            this.pnlConfirmPassError.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlConfirmPassError.Name = "pnlConfirmPassError";
            this.pnlConfirmPassError.Size = new System.Drawing.Size(301, 24);
            this.pnlConfirmPassError.TabIndex = 24;
            this.pnlConfirmPassError.Visible = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChangePass.Location = new System.Drawing.Point(327, 29);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(100, 28);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Enter";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // pnlChangePasswordError
            // 
            this.pnlChangePasswordError.BackColor = System.Drawing.Color.Red;
            this.pnlChangePasswordError.Location = new System.Drawing.Point(13, 29);
            this.pnlChangePasswordError.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChangePasswordError.Name = "pnlChangePasswordError";
            this.pnlChangePasswordError.Size = new System.Drawing.Size(300, 19);
            this.pnlChangePasswordError.TabIndex = 19;
            this.pnlChangePasswordError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Red;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordError.Location = new System.Drawing.Point(26, 352);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(286, 17);
            this.lblPasswordError.TabIndex = 17;
            this.lblPasswordError.Text = "Password must be longer than 8 characters.";
            this.lblPasswordError.Visible = false;
            // 
            // lblUserErrorDisplay
            // 
            this.lblUserErrorDisplay.AutoSize = true;
            this.lblUserErrorDisplay.BackColor = System.Drawing.Color.Red;
            this.lblUserErrorDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblUserErrorDisplay.Location = new System.Drawing.Point(447, 80);
            this.lblUserErrorDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserErrorDisplay.Name = "lblUserErrorDisplay";
            this.lblUserErrorDisplay.Size = new System.Drawing.Size(137, 17);
            this.lblUserErrorDisplay.TabIndex = 12;
            this.lblUserErrorDisplay.Text = "Username not found";
            this.lblUserErrorDisplay.Visible = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Red;
            this.pnlUsername.Location = new System.Drawing.Point(29, 75);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(301, 19);
            this.pnlUsername.TabIndex = 13;
            this.pnlUsername.Visible = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.forgotpassbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 383);
            this.Controls.Add(this.lblUserErrorDisplay);
            this.Controls.Add(this.pnlPasswordDisplay);
            this.Controls.Add(this.pnlSecQuestions);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbUsernameRecovery);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.pnlUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.pnlSecQuestions.ResumeLayout(false);
            this.pnlSecQuestions.PerformLayout();
            this.pnlPasswordDisplay.ResumeLayout(false);
            this.pnlPasswordDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.TextBox tbUsernameRecovery;
        private System.Windows.Forms.Label lblDisplaySecurityQuestion;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbSQAnswer;
        private System.Windows.Forms.Button btnSQEnter;
        private System.Windows.Forms.Label lblDisplayChangePass;
        private System.Windows.Forms.Panel pnlSecQuestions;
        private System.Windows.Forms.Panel pnlPasswordDisplay;
        private System.Windows.Forms.Label lblUserErrorDisplay;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlSecurityQuestionError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSQError;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Panel pnlChangePasswordError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfimPass;
        private System.Windows.Forms.Panel pnlConfirmPassError;
        private System.Windows.Forms.Button btnNewPassShow;
        private System.Windows.Forms.Button btnConfirmPassShow;
    }
}