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
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.pnlChangePasswordError = new System.Windows.Forms.Panel();
            this.lblUserErrorDisplay = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfimPass = new System.Windows.Forms.TextBox();
            this.pnlConfirmPassError = new System.Windows.Forms.Panel();
            this.btnNewPassShow = new System.Windows.Forms.Button();
            this.btnConfirmPassShow = new System.Windows.Forms.Button();
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
            this.lblFormTitle.Location = new System.Drawing.Point(24, 24);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(393, 54);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Forgot Password";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDisplayUsername.Location = new System.Drawing.Point(35, 89);
            this.lblDisplayUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(108, 25);
            this.lblDisplayUsername.TabIndex = 1;
            this.lblDisplayUsername.Text = "Username:";
            // 
            // tbUsernameRecovery
            // 
            this.tbUsernameRecovery.Location = new System.Drawing.Point(40, 120);
            this.tbUsernameRecovery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbUsernameRecovery.Name = "tbUsernameRecovery";
            this.tbUsernameRecovery.Size = new System.Drawing.Size(411, 29);
            this.tbUsernameRecovery.TabIndex = 2;
            this.tbUsernameRecovery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsernameRecovery_KeyDown);
            // 
            // lblDisplaySecurityQuestion
            // 
            this.lblDisplaySecurityQuestion.AutoSize = true;
            this.lblDisplaySecurityQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplaySecurityQuestion.Location = new System.Drawing.Point(18, 9);
            this.lblDisplaySecurityQuestion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplaySecurityQuestion.Name = "lblDisplaySecurityQuestion";
            this.lblDisplaySecurityQuestion.Size = new System.Drawing.Size(238, 25);
            this.lblDisplaySecurityQuestion.TabIndex = 3;
            this.lblDisplaySecurityQuestion.Text = "Answer Security Question";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(18, 33);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(52, 25);
            this.lblSecurityQuestion.TabIndex = 4;
            this.lblSecurityQuestion.Text = "Hide";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(466, 116);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(138, 42);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbSQAnswer
            // 
            this.tbSQAnswer.Location = new System.Drawing.Point(24, 68);
            this.tbSQAnswer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSQAnswer.Name = "tbSQAnswer";
            this.tbSQAnswer.Size = new System.Drawing.Size(411, 29);
            this.tbSQAnswer.TabIndex = 6;
            this.tbSQAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnSQEnter
            // 
            this.btnSQEnter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSQEnter.Location = new System.Drawing.Point(449, 65);
            this.btnSQEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSQEnter.Name = "btnSQEnter";
            this.btnSQEnter.Size = new System.Drawing.Size(138, 42);
            this.btnSQEnter.TabIndex = 7;
            this.btnSQEnter.Text = "Enter";
            this.btnSQEnter.UseVisualStyleBackColor = true;
            this.btnSQEnter.Click += new System.EventHandler(this.btnSQEnter_Click);
            // 
            // lblDisplayChangePass
            // 
            this.lblDisplayChangePass.AutoSize = true;
            this.lblDisplayChangePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplayChangePass.Location = new System.Drawing.Point(18, 13);
            this.lblDisplayChangePass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayChangePass.Name = "lblDisplayChangePass";
            this.lblDisplayChangePass.Size = new System.Drawing.Size(173, 25);
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
            this.pnlSecQuestions.Location = new System.Drawing.Point(22, 168);
            this.pnlSecQuestions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSecQuestions.Name = "pnlSecQuestions";
            this.pnlSecQuestions.Size = new System.Drawing.Size(840, 129);
            this.pnlSecQuestions.TabIndex = 10;
            this.pnlSecQuestions.Visible = false;
            // 
            // lblSQError
            // 
            this.lblSQError.AutoSize = true;
            this.lblSQError.BackColor = System.Drawing.Color.Red;
            this.lblSQError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSQError.Location = new System.Drawing.Point(594, 81);
            this.lblSQError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSQError.Name = "lblSQError";
            this.lblSQError.Size = new System.Drawing.Size(71, 25);
            this.lblSQError.TabIndex = 16;
            this.lblSQError.Text = "Wrong";
            this.lblSQError.Visible = false;
            // 
            // pnlSecurityQuestionError
            // 
            this.pnlSecurityQuestionError.BackColor = System.Drawing.Color.Red;
            this.pnlSecurityQuestionError.Location = new System.Drawing.Point(24, 59);
            this.pnlSecurityQuestionError.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSecurityQuestionError.Name = "pnlSecurityQuestionError";
            this.pnlSecurityQuestionError.Size = new System.Drawing.Size(414, 22);
            this.pnlSecurityQuestionError.TabIndex = 14;
            this.pnlSecurityQuestionError.Visible = false;
            // 
            // pnlPasswordDisplay
            // 
            this.pnlPasswordDisplay.Controls.Add(this.btnConfirmPassShow);
            this.pnlPasswordDisplay.Controls.Add(this.btnNewPassShow);
            this.pnlPasswordDisplay.Controls.Add(this.label1);
            this.pnlPasswordDisplay.Controls.Add(this.label2);
            this.pnlPasswordDisplay.Controls.Add(this.tbConfimPass);
            this.pnlPasswordDisplay.Controls.Add(this.pnlConfirmPassError);
            this.pnlPasswordDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordDisplay.Controls.Add(this.lblPasswordError);
            this.pnlPasswordDisplay.Controls.Add(this.btnChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.lblDisplayChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.tbNewPassword);
            this.pnlPasswordDisplay.Controls.Add(this.pnlChangePasswordError);
            this.pnlPasswordDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.pnlPasswordDisplay.Location = new System.Drawing.Point(22, 308);
            this.pnlPasswordDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlPasswordDisplay.Name = "pnlPasswordDisplay";
            this.pnlPasswordDisplay.Size = new System.Drawing.Size(840, 122);
            this.pnlPasswordDisplay.TabIndex = 11;
            this.pnlPasswordDisplay.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Red;
            this.lblPasswordError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPasswordError.Location = new System.Drawing.Point(594, 61);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(26, 25);
            this.lblPasswordError.TabIndex = 17;
            this.lblPasswordError.Text = "X";
            this.lblPasswordError.Visible = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChangePass.Location = new System.Drawing.Point(449, 44);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(138, 42);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Enter";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // tbNewPassword
            // 
            this.tbChangePass.Location = new System.Drawing.Point(24, 48);
            this.tbChangePass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbChangePass.Name = "tbChangePass";
            this.tbChangePass.Size = new System.Drawing.Size(411, 29);
            this.tbChangePass.TabIndex = 17;
            this.tbChangePass.UseSystemPasswordChar = true;
            this.tbChangePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangePass_KeyDown);
            this.tbNewPassword.Location = new System.Drawing.Point(35, 62);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(596, 38);
            this.tbNewPassword.TabIndex = 5;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChangePass_KeyDown);
            // 
            // pnlChangePasswordError
            // 
            this.pnlChangePasswordError.BackColor = System.Drawing.Color.Red;
            this.pnlChangePasswordError.Location = new System.Drawing.Point(24, 41);
            this.pnlChangePasswordError.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlChangePasswordError.Name = "pnlChangePasswordError";
            this.pnlChangePasswordError.Size = new System.Drawing.Size(414, 28);
            this.pnlChangePasswordError.TabIndex = 19;
            this.pnlChangePasswordError.Visible = false;
            // 
            // lblUserErrorDisplay
            // 
            this.lblUserErrorDisplay.AutoSize = true;
            this.lblUserErrorDisplay.BackColor = System.Drawing.Color.Red;
            this.lblUserErrorDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserErrorDisplay.Location = new System.Drawing.Point(616, 133);
            this.lblUserErrorDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserErrorDisplay.Name = "lblUserErrorDisplay";
            this.lblUserErrorDisplay.Size = new System.Drawing.Size(188, 25);
            this.lblUserErrorDisplay.TabIndex = 12;
            this.lblUserErrorDisplay.Text = "Username not found";
            this.lblUserErrorDisplay.Visible = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Red;
            this.pnlUsername.Location = new System.Drawing.Point(40, 113);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(414, 28);
            this.pnlUsername.TabIndex = 13;
            this.pnlUsername.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 441);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(932, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "X";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confim Password";
            // 
            // tbConfimPass
            // 
            this.tbConfimPass.Location = new System.Drawing.Point(33, 155);
            this.tbConfimPass.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbConfimPass.Name = "tbConfimPass";
            this.tbConfimPass.Size = new System.Drawing.Size(596, 38);
            this.tbConfimPass.TabIndex = 6;
            this.tbConfimPass.UseSystemPasswordChar = true;
            // 
            // pnlConfirmPassError
            // 
            this.pnlConfirmPassError.BackColor = System.Drawing.Color.Red;
            this.pnlConfirmPassError.Location = new System.Drawing.Point(33, 145);
            this.pnlConfirmPassError.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlConfirmPassError.Name = "pnlConfirmPassError";
            this.pnlConfirmPassError.Size = new System.Drawing.Size(603, 36);
            this.pnlConfirmPassError.TabIndex = 24;
            this.pnlConfirmPassError.Visible = false;
            // 
            // btnNewPassShow
            // 
            this.btnNewPassShow.Location = new System.Drawing.Point(645, 52);
            this.btnNewPassShow.Name = "btnNewPassShow";
            this.btnNewPassShow.Size = new System.Drawing.Size(48, 47);
            this.btnNewPassShow.TabIndex = 16;
            this.btnNewPassShow.Text = "Eye";
            this.btnNewPassShow.UseVisualStyleBackColor = true;
            this.btnNewPassShow.Click += new System.EventHandler(this.btnNewPassShow_Click);
            // 
            // btnConfirmPassShow
            // 
            this.btnConfirmPassShow.Location = new System.Drawing.Point(645, 138);
            this.btnConfirmPassShow.Name = "btnConfirmPassShow";
            this.btnConfirmPassShow.Size = new System.Drawing.Size(48, 46);
            this.btnConfirmPassShow.TabIndex = 25;
            this.btnConfirmPassShow.Text = "Eye";
            this.btnConfirmPassShow.UseVisualStyleBackColor = true;
            this.btnConfirmPassShow.Click += new System.EventHandler(this.btnConfirmPassShow_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.forgotpassback__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 502);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUserErrorDisplay);
            this.Controls.Add(this.pnlPasswordDisplay);
            this.Controls.Add(this.pnlSecQuestions);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbUsernameRecovery);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pnlUsername);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ForgotPassword";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfimPass;
        private System.Windows.Forms.Panel pnlConfirmPassError;
        private System.Windows.Forms.Button btnConfirmPassShow;
        private System.Windows.Forms.Button btnNewPassShow;
    }
}