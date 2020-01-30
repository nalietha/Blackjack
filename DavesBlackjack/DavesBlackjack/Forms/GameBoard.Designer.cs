using System.Collections.Generic;
using System.Windows.Forms;

namespace DavesBlackjack
{
    partial class GameBoard
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
            System.Windows.Forms.Label label420;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.d8 = new System.Windows.Forms.PictureBox();
            this.d7 = new System.Windows.Forms.PictureBox();
            this.d6 = new System.Windows.Forms.PictureBox();
            this.d5 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.d3 = new System.Windows.Forms.PictureBox();
            this.d2 = new System.Windows.Forms.PictureBox();
            this.d1 = new System.Windows.Forms.PictureBox();
            this.playerName = new System.Windows.Forms.Label();
            this.dealerName = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.betUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.playerBalance = new System.Windows.Forms.Label();
            this.insuranceUpDown = new System.Windows.Forms.NumericUpDown();
            this.insuranceButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addNewPlayerButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.dTotalString = new System.Windows.Forms.Label();
            this.pTotalString = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            label420 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label420
            // 
            label420.AutoSize = true;
            label420.BackColor = System.Drawing.Color.Transparent;
            label420.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label420.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label420.Location = new System.Drawing.Point(12, 266);
            label420.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label420.Name = "label420";
            label420.Size = new System.Drawing.Size(202, 33);
            label420.TabIndex = 26;
            label420.Text = "Lifetime Wins:";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p1.Location = new System.Drawing.Point(13, 70);
            this.p1.Margin = new System.Windows.Forms.Padding(2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(103, 148);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p2.Location = new System.Drawing.Point(40, 70);
            this.p2.Margin = new System.Windows.Forms.Padding(2);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(103, 148);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 2;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p3.Location = new System.Drawing.Point(67, 70);
            this.p3.Margin = new System.Windows.Forms.Padding(2);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(103, 148);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 3;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p4.Location = new System.Drawing.Point(93, 70);
            this.p4.Margin = new System.Windows.Forms.Padding(2);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(103, 148);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p4.TabIndex = 4;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.Transparent;
            this.p5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p5.Location = new System.Drawing.Point(120, 70);
            this.p5.Margin = new System.Windows.Forms.Padding(2);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(103, 148);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p5.TabIndex = 5;
            this.p5.TabStop = false;
            this.p5.Visible = false;
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.Transparent;
            this.p6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p6.Location = new System.Drawing.Point(147, 70);
            this.p6.Margin = new System.Windows.Forms.Padding(2);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(103, 148);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p6.TabIndex = 6;
            this.p6.TabStop = false;
            this.p6.Visible = false;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.Color.Transparent;
            this.p7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p7.Location = new System.Drawing.Point(173, 70);
            this.p7.Margin = new System.Windows.Forms.Padding(2);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(103, 148);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p7.TabIndex = 7;
            this.p7.TabStop = false;
            this.p7.Visible = false;
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.Color.Transparent;
            this.p8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p8.Location = new System.Drawing.Point(200, 70);
            this.p8.Margin = new System.Windows.Forms.Padding(2);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(103, 148);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p8.TabIndex = 8;
            this.p8.TabStop = false;
            this.p8.Visible = false;
            // 
            // d8
            // 
            this.d8.BackColor = System.Drawing.Color.Transparent;
            this.d8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d8.Location = new System.Drawing.Point(648, 70);
            this.d8.Margin = new System.Windows.Forms.Padding(2);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(103, 148);
            this.d8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d8.TabIndex = 16;
            this.d8.TabStop = false;
            this.d8.Visible = false;
            // 
            // d7
            // 
            this.d7.BackColor = System.Drawing.Color.Transparent;
            this.d7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d7.Location = new System.Drawing.Point(621, 70);
            this.d7.Margin = new System.Windows.Forms.Padding(2);
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(103, 148);
            this.d7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d7.TabIndex = 15;
            this.d7.TabStop = false;
            this.d7.Visible = false;
            // 
            // d6
            // 
            this.d6.BackColor = System.Drawing.Color.Transparent;
            this.d6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d6.Location = new System.Drawing.Point(595, 70);
            this.d6.Margin = new System.Windows.Forms.Padding(2);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(103, 148);
            this.d6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d6.TabIndex = 14;
            this.d6.TabStop = false;
            this.d6.Visible = false;
            // 
            // d5
            // 
            this.d5.BackColor = System.Drawing.Color.Transparent;
            this.d5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d5.Location = new System.Drawing.Point(568, 70);
            this.d5.Margin = new System.Windows.Forms.Padding(2);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(103, 148);
            this.d5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d5.TabIndex = 13;
            this.d5.TabStop = false;
            this.d5.Visible = false;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.Transparent;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d4.Location = new System.Drawing.Point(541, 70);
            this.d4.Margin = new System.Windows.Forms.Padding(2);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(103, 148);
            this.d4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d4.TabIndex = 12;
            this.d4.TabStop = false;
            this.d4.Visible = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.Transparent;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d3.Location = new System.Drawing.Point(515, 70);
            this.d3.Margin = new System.Windows.Forms.Padding(2);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(103, 148);
            this.d3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d3.TabIndex = 11;
            this.d3.TabStop = false;
            this.d3.Visible = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.Transparent;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d2.Location = new System.Drawing.Point(488, 70);
            this.d2.Margin = new System.Windows.Forms.Padding(2);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(103, 148);
            this.d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d2.TabIndex = 10;
            this.d2.TabStop = false;
            this.d2.Visible = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.Transparent;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.d1.Location = new System.Drawing.Point(461, 70);
            this.d1.Margin = new System.Windows.Forms.Padding(2);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(103, 148);
            this.d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d1.TabIndex = 9;
            this.d1.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerName.Location = new System.Drawing.Point(11, 21);
            this.playerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(169, 47);
            this.playerName.TabIndex = 17;
            this.playerName.Text = "Player 1";
            // 
            // dealerName
            // 
            this.dealerName.AutoSize = true;
            this.dealerName.BackColor = System.Drawing.Color.Transparent;
            this.dealerName.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerName.Location = new System.Drawing.Point(454, 21);
            this.dealerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerName.Name = "dealerName";
            this.dealerName.Size = new System.Drawing.Size(141, 47);
            this.dealerName.TabIndex = 18;
            this.dealerName.Text = "Dealer";
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Transparent;
            this.hitButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.hit;
            this.hitButton.Enabled = false;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(18, 380);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(140, 45);
            this.hitButton.TabIndex = 21;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.Color.Transparent;
            this.stayButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.stay;
            this.stayButton.Enabled = false;
            this.stayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stayButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayButton.Location = new System.Drawing.Point(18, 429);
            this.stayButton.Margin = new System.Windows.Forms.Padding(2);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(140, 45);
            this.stayButton.TabIndex = 22;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerScore.Location = new System.Drawing.Point(409, 108);
            this.playerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(32, 33);
            this.playerScore.TabIndex = 24;
            this.playerScore.Text = "0";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.BackColor = System.Drawing.Color.Transparent;
            this.dealerScore.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerScore.Location = new System.Drawing.Point(407, 150);
            this.dealerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(49, 33);
            this.dealerScore.TabIndex = 25;
            this.dealerScore.Text = "XX";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.BackColor = System.Drawing.Color.Transparent;
            this.wins.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wins.Location = new System.Drawing.Point(244, 266);
            this.wins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(32, 33);
            this.wins.TabIndex = 27;
            this.wins.Text = "0";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.BackColor = System.Drawing.Color.Transparent;
            this.losses.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.losses.Location = new System.Drawing.Point(244, 299);
            this.losses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(32, 33);
            this.losses.TabIndex = 29;
            this.losses.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "Session Losses:";
            // 
            // betUpDown
            // 
            this.betUpDown.AutoSize = true;
            this.betUpDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.betUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betUpDown.Location = new System.Drawing.Point(187, 418);
            this.betUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.betUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.betUpDown.Name = "betUpDown";
            this.betUpDown.Size = new System.Drawing.Size(100, 22);
            this.betUpDown.TabIndex = 32;
            this.betUpDown.ThousandsSeparator = true;
            this.betUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.betUpDown.ValueChanged += new System.EventHandler(this.betUpDown_ValueChanged);
            // 
            // betButton
            // 
            this.betButton.AutoSize = true;
            this.betButton.Location = new System.Drawing.Point(187, 449);
            this.betButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(100, 30);
            this.betButton.TabIndex = 33;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // playerBalance
            // 
            this.playerBalance.AutoSize = true;
            this.playerBalance.BackColor = System.Drawing.Color.Transparent;
            this.playerBalance.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerBalance.Location = new System.Drawing.Point(15, 225);
            this.playerBalance.Name = "playerBalance";
            this.playerBalance.Size = new System.Drawing.Size(55, 38);
            this.playerBalance.TabIndex = 34;
            this.playerBalance.Text = "$0";
            // 
            // insuranceUpDown
            // 
            this.insuranceUpDown.Location = new System.Drawing.Point(302, 418);
            this.insuranceUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceUpDown.Name = "insuranceUpDown";
            this.insuranceUpDown.Size = new System.Drawing.Size(100, 22);
            this.insuranceUpDown.TabIndex = 35;
            this.insuranceUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.insuranceUpDown.Visible = false;
            this.insuranceUpDown.ValueChanged += new System.EventHandler(this.insuranceUpDown_ValueChanged);
            // 
            // insuranceButton
            // 
            this.insuranceButton.Location = new System.Drawing.Point(302, 449);
            this.insuranceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(100, 30);
            this.insuranceButton.TabIndex = 36;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Visible = false;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(654, 449);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(100, 30);
            this.profileButton.TabIndex = 37;
            this.profileButton.Text = "My Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Transparent;
            this.skipButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.skip;
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skipButton.FlatAppearance.BorderSize = 0;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skipButton.Location = new System.Drawing.Point(681, 12);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(32, 32);
            this.skipButton.TabIndex = 39;
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.soundOff;
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.muteButton.Location = new System.Drawing.Point(643, 12);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(32, 32);
            this.muteButton.TabIndex = 38;
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(654, 415);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 30);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.Location = new System.Drawing.Point(549, 415);
            this.addNewPlayerButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(100, 30);
            this.addNewPlayerButton.TabIndex = 41;
            this.addNewPlayerButton.Text = "New Player";
            this.addNewPlayerButton.UseVisualStyleBackColor = true;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(549, 449);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 30);
            this.logOutButton.TabIndex = 43;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.BackColor = System.Drawing.Color.Transparent;
            this.endTurnButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.endturn;
            this.endTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endTurnButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTurnButton.Location = new System.Drawing.Point(18, 331);
            this.endTurnButton.Margin = new System.Windows.Forms.Padding(2);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(140, 45);
            this.endTurnButton.TabIndex = 44;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = false;
            this.endTurnButton.Visible = false;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // dTotalString
            // 
            this.dTotalString.AccessibleDescription = "Total: __(score)";
            this.dTotalString.AutoSize = true;
            this.dTotalString.BackColor = System.Drawing.Color.Transparent;
            this.dTotalString.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTotalString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dTotalString.Location = new System.Drawing.Point(306, 150);
            this.dTotalString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dTotalString.Name = "dTotalString";
            this.dTotalString.Size = new System.Drawing.Size(110, 33);
            this.dTotalString.TabIndex = 20;
            this.dTotalString.Text = "Dealer:";
            // 
            // pTotalString
            // 
            this.pTotalString.AccessibleDescription = "Total: __(score)";
            this.pTotalString.AutoSize = true;
            this.pTotalString.BackColor = System.Drawing.Color.Transparent;
            this.pTotalString.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTotalString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pTotalString.Location = new System.Drawing.Point(307, 108);
            this.pTotalString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pTotalString.Name = "pTotalString";
            this.pTotalString.Size = new System.Drawing.Size(105, 33);
            this.pTotalString.TabIndex = 19;
            this.pTotalString.Text = "Player:";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.close;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Location = new System.Drawing.Point(719, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 45;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.gameboardbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 490);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addNewPlayerButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.insuranceButton);
            this.Controls.Add(this.insuranceUpDown);
            this.Controls.Add(this.playerBalance);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.betUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(label420);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dTotalString);
            this.Controls.Add(this.pTotalString);
            this.Controls.Add(this.dealerName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d7);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.d5);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameBoard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox d8;
        private System.Windows.Forms.PictureBox d7;
        private System.Windows.Forms.PictureBox d6;
        private System.Windows.Forms.PictureBox d5;
        private System.Windows.Forms.PictureBox d4;
        private System.Windows.Forms.PictureBox d3;
        private System.Windows.Forms.PictureBox d2;
        private System.Windows.Forms.PictureBox d1;
        private Label playerName;
        private Label dealerName;
        private Button hitButton;
        private Button stayButton;
        private Label playerScore;
        private Label dealerScore;
        private Label wins;
        private Label losses;
        private Label label4;
        private NumericUpDown betUpDown;
        private Button betButton;
        private Label playerBalance;
        private NumericUpDown insuranceUpDown;
        private Button insuranceButton;
        private Button profileButton;
        private Button skipButton;
        private Button muteButton;
        private Button saveButton;
        private Button addNewPlayerButton;
        private Button logOutButton;
        private Button endTurnButton;
        private Label dTotalString;
        private Label pTotalString;
        private Button closeButton;
    }
}

