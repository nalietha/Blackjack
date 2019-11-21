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
            this.lblUserErrorDisplay = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.tbChangePass = new System.Windows.Forms.TextBox();
            this.pnlChangePasswordError = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.pnlSecQuestions.SuspendLayout();
            this.pnlPasswordDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(13, 13);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(235, 31);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Forgot Password";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.Location = new System.Drawing.Point(19, 48);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(58, 13);
            this.lblDisplayUsername.TabIndex = 1;
            this.lblDisplayUsername.Text = "Username:";
            // 
            // tbUsernameRecovery
            // 
            this.tbUsernameRecovery.Location = new System.Drawing.Point(22, 65);
            this.tbUsernameRecovery.Name = "tbUsernameRecovery";
            this.tbUsernameRecovery.Size = new System.Drawing.Size(226, 20);
            this.tbUsernameRecovery.TabIndex = 2;
            this.tbUsernameRecovery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsernameRecovery_KeyDown);
            // 
            // lblDisplaySecurityQuestion
            // 
            this.lblDisplaySecurityQuestion.AutoSize = true;
            this.lblDisplaySecurityQuestion.Location = new System.Drawing.Point(10, 5);
            this.lblDisplaySecurityQuestion.Name = "lblDisplaySecurityQuestion";
            this.lblDisplaySecurityQuestion.Size = new System.Drawing.Size(128, 13);
            this.lblDisplaySecurityQuestion.TabIndex = 3;
            this.lblDisplaySecurityQuestion.Text = "Answer Security Question";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(10, 18);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(29, 13);
            this.lblSecurityQuestion.TabIndex = 4;
            this.lblSecurityQuestion.Text = "Hide";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(254, 63);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbSQAnswer
            // 
            this.tbSQAnswer.Location = new System.Drawing.Point(13, 37);
            this.tbSQAnswer.Name = "tbSQAnswer";
            this.tbSQAnswer.Size = new System.Drawing.Size(226, 20);
            this.tbSQAnswer.TabIndex = 6;
            this.tbSQAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnSQEnter
            // 
            this.btnSQEnter.Location = new System.Drawing.Point(245, 35);
            this.btnSQEnter.Name = "btnSQEnter";
            this.btnSQEnter.Size = new System.Drawing.Size(75, 23);
            this.btnSQEnter.TabIndex = 7;
            this.btnSQEnter.Text = "Enter";
            this.btnSQEnter.UseVisualStyleBackColor = true;
            this.btnSQEnter.Click += new System.EventHandler(this.btnSQEnter_Click);
            // 
            // lblDisplayChangePass
            // 
            this.lblDisplayChangePass.AutoSize = true;
            this.lblDisplayChangePass.Location = new System.Drawing.Point(10, 7);
            this.lblDisplayChangePass.Name = "lblDisplayChangePass";
            this.lblDisplayChangePass.Size = new System.Drawing.Size(93, 13);
            this.lblDisplayChangePass.TabIndex = 8;
            this.lblDisplayChangePass.Text = "Change Password";
            // 
            // pnlSecQuestions
            // 
            this.pnlSecQuestions.Controls.Add(this.lblSQError);
            this.pnlSecQuestions.Controls.Add(this.tbSQAnswer);
            this.pnlSecQuestions.Controls.Add(this.lblDisplaySecurityQuestion);
            this.pnlSecQuestions.Controls.Add(this.lblSecurityQuestion);
            this.pnlSecQuestions.Controls.Add(this.btnSQEnter);
            this.pnlSecQuestions.Controls.Add(this.pnlSecurityQuestionError);
            this.pnlSecQuestions.Location = new System.Drawing.Point(12, 91);
            this.pnlSecQuestions.Name = "pnlSecQuestions";
            this.pnlSecQuestions.Size = new System.Drawing.Size(458, 70);
            this.pnlSecQuestions.TabIndex = 10;
            this.pnlSecQuestions.Visible = false;
            // 
            // lblSQError
            // 
            this.lblSQError.AutoSize = true;
            this.lblSQError.ForeColor = System.Drawing.Color.Red;
            this.lblSQError.Location = new System.Drawing.Point(324, 44);
            this.lblSQError.Name = "lblSQError";
            this.lblSQError.Size = new System.Drawing.Size(39, 13);
            this.lblSQError.TabIndex = 16;
            this.lblSQError.Text = "Wrong";
            this.lblSQError.Visible = false;
            // 
            // pnlSecurityQuestionError
            // 
            this.pnlSecurityQuestionError.BackColor = System.Drawing.Color.Red;
            this.pnlSecurityQuestionError.Location = new System.Drawing.Point(13, 32);
            this.pnlSecurityQuestionError.Name = "pnlSecurityQuestionError";
            this.pnlSecurityQuestionError.Size = new System.Drawing.Size(226, 12);
            this.pnlSecurityQuestionError.TabIndex = 14;
            this.pnlSecurityQuestionError.Visible = false;
            // 
            // pnlPasswordDisplay
            // 
            this.pnlPasswordDisplay.Controls.Add(this.lblPasswordError);
            this.pnlPasswordDisplay.Controls.Add(this.btnChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.lblDisplayChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.tbChangePass);
            this.pnlPasswordDisplay.Controls.Add(this.pnlChangePasswordError);
            this.pnlPasswordDisplay.Location = new System.Drawing.Point(12, 167);
            this.pnlPasswordDisplay.Name = "pnlPasswordDisplay";
            this.pnlPasswordDisplay.Size = new System.Drawing.Size(458, 66);
            this.pnlPasswordDisplay.TabIndex = 11;
            this.pnlPasswordDisplay.Visible = false;
            // 
            // lblUserErrorDisplay
            // 
            this.lblUserErrorDisplay.AutoSize = true;
            this.lblUserErrorDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblUserErrorDisplay.Location = new System.Drawing.Point(336, 72);
            this.lblUserErrorDisplay.Name = "lblUserErrorDisplay";
            this.lblUserErrorDisplay.Size = new System.Drawing.Size(103, 13);
            this.lblUserErrorDisplay.TabIndex = 12;
            this.lblUserErrorDisplay.Text = "Username not found";
            this.lblUserErrorDisplay.Visible = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Red;
            this.pnlUsername.Location = new System.Drawing.Point(22, 61);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(226, 15);
            this.pnlUsername.TabIndex = 13;
            this.pnlUsername.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(245, 24);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(75, 23);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Enter";
            this.btnChangePass.UseVisualStyleBackColor = true;
            // 
            // tbChangePass
            // 
            this.tbChangePass.Location = new System.Drawing.Point(13, 26);
            this.tbChangePass.Name = "tbChangePass";
            this.tbChangePass.Size = new System.Drawing.Size(226, 20);
            this.tbChangePass.TabIndex = 17;
            // 
            // pnlChangePasswordError
            // 
            this.pnlChangePasswordError.BackColor = System.Drawing.Color.Red;
            this.pnlChangePasswordError.Location = new System.Drawing.Point(13, 22);
            this.pnlChangePasswordError.Name = "pnlChangePasswordError";
            this.pnlChangePasswordError.Size = new System.Drawing.Size(226, 15);
            this.pnlChangePasswordError.TabIndex = 19;
            this.pnlChangePasswordError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(324, 33);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(39, 13);
            this.lblPasswordError.TabIndex = 17;
            this.lblPasswordError.Text = "Wrong";
            this.lblPasswordError.Visible = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUserErrorDisplay);
            this.Controls.Add(this.pnlPasswordDisplay);
            this.Controls.Add(this.pnlSecQuestions);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbUsernameRecovery);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pnlUsername);
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
        private System.Windows.Forms.TextBox tbChangePass;
        private System.Windows.Forms.Panel pnlChangePasswordError;
        private System.Windows.Forms.Label lblPasswordError;
    }
}