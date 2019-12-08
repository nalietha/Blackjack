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
            this.pTotalString = new System.Windows.Forms.Label();
            this.dealerString = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.endTurnButton = new System.Windows.Forms.Button();
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
            label420.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label420.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label420.Location = new System.Drawing.Point(366, 717);
            label420.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label420.Name = "label420";
            label420.Size = new System.Drawing.Size(107, 48);
            label420.TabIndex = 26;
            label420.Text = "WINS";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Location = new System.Drawing.Point(30, 107);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(232, 287);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Location = new System.Drawing.Point(84, 107);
            this.p2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(232, 287);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 2;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.Location = new System.Drawing.Point(138, 107);
            this.p3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(232, 287);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 3;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.Location = new System.Drawing.Point(190, 107);
            this.p4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(232, 287);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 4;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.Transparent;
            this.p5.Location = new System.Drawing.Point(244, 107);
            this.p5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(232, 287);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 5;
            this.p5.TabStop = false;
            this.p5.Visible = false;
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.Transparent;
            this.p6.Location = new System.Drawing.Point(298, 107);
            this.p6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(232, 287);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 6;
            this.p6.TabStop = false;
            this.p6.Visible = false;
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.Color.Transparent;
            this.p7.Location = new System.Drawing.Point(350, 107);
            this.p7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(232, 287);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p7.TabIndex = 7;
            this.p7.TabStop = false;
            this.p7.Visible = false;
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.Color.Transparent;
            this.p8.Location = new System.Drawing.Point(404, 107);
            this.p8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(232, 287);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p8.TabIndex = 8;
            this.p8.TabStop = false;
            this.p8.Visible = false;
            // 
            // d8
            // 
            this.d8.BackColor = System.Drawing.Color.Transparent;
            this.d8.Location = new System.Drawing.Point(1364, 107);
            this.d8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(232, 287);
            this.d8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d8.TabIndex = 16;
            this.d8.TabStop = false;
            this.d8.Visible = false;
            // 
            // d7
            // 
            this.d7.BackColor = System.Drawing.Color.Transparent;
            this.d7.Location = new System.Drawing.Point(1310, 107);
            this.d7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(232, 287);
            this.d7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d7.TabIndex = 15;
            this.d7.TabStop = false;
            this.d7.Visible = false;
            // 
            // d6
            // 
            this.d6.BackColor = System.Drawing.Color.Transparent;
            this.d6.Location = new System.Drawing.Point(1258, 107);
            this.d6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(232, 287);
            this.d6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d6.TabIndex = 14;
            this.d6.TabStop = false;
            this.d6.Visible = false;
            // 
            // d5
            // 
            this.d5.BackColor = System.Drawing.Color.Transparent;
            this.d5.Location = new System.Drawing.Point(1204, 107);
            this.d5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(232, 287);
            this.d5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d5.TabIndex = 13;
            this.d5.TabStop = false;
            this.d5.Visible = false;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.Transparent;
            this.d4.Location = new System.Drawing.Point(1150, 107);
            this.d4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(232, 287);
            this.d4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d4.TabIndex = 12;
            this.d4.TabStop = false;
            this.d4.Visible = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.Transparent;
            this.d3.Location = new System.Drawing.Point(1098, 107);
            this.d3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(232, 287);
            this.d3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d3.TabIndex = 11;
            this.d3.TabStop = false;
            this.d3.Visible = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.Transparent;
            this.d2.Location = new System.Drawing.Point(1044, 107);
            this.d2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(232, 287);
            this.d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d2.TabIndex = 10;
            this.d2.TabStop = false;
            this.d2.Visible = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.Transparent;
            this.d1.Location = new System.Drawing.Point(990, 107);
            this.d1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(232, 287);
            this.d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d1.TabIndex = 9;
            this.d1.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerName.Location = new System.Drawing.Point(26, 12);
            this.playerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(254, 83);
            this.playerName.TabIndex = 17;
            this.playerName.Text = "Player 1";
            // 
            // dealerName
            // 
            this.dealerName.AutoSize = true;
            this.dealerName.BackColor = System.Drawing.Color.Transparent;
            this.dealerName.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerName.Location = new System.Drawing.Point(976, 12);
            this.dealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerName.Name = "dealerName";
            this.dealerName.Size = new System.Drawing.Size(256, 83);
            this.dealerName.TabIndex = 18;
            this.dealerName.Text = "Dealer";
            // 
            // pTotalString
            // 
            this.pTotalString.AccessibleDescription = "Total: __(score)";
            this.pTotalString.AutoSize = true;
            this.pTotalString.BackColor = System.Drawing.Color.Transparent;
            this.pTotalString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTotalString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pTotalString.Location = new System.Drawing.Point(22, 432);
            this.pTotalString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pTotalString.Name = "pTotalString";
            this.pTotalString.Size = new System.Drawing.Size(138, 46);
            this.pTotalString.TabIndex = 19;
            this.pTotalString.Text = "Total: ";
            // 
            // dealerString
            // 
            this.dealerString.AccessibleDescription = "Total: __(score)";
            this.dealerString.AutoSize = true;
            this.dealerString.BackColor = System.Drawing.Color.Transparent;
            this.dealerString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerString.Location = new System.Drawing.Point(982, 432);
            this.dealerString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerString.Name = "dealerString";
            this.dealerString.Size = new System.Drawing.Size(138, 46);
            this.dealerString.TabIndex = 20;
            this.dealerString.Text = "Total: ";
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Transparent;
            this.hitButton.BackgroundImage = global::DavesBlackjack.Properties.Resources.hit;
            this.hitButton.Enabled = false;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(44, 552);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(270, 95);
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
            this.stayButton.Location = new System.Drawing.Point(44, 670);
            this.stayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(270, 95);
            this.stayButton.TabIndex = 22;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerScore.Location = new System.Drawing.Point(178, 432);
            this.playerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(74, 46);
            this.playerScore.TabIndex = 24;
            this.playerScore.Text = "XX";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.BackColor = System.Drawing.Color.Transparent;
            this.dealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dealerScore.Location = new System.Drawing.Point(1138, 432);
            this.dealerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(74, 46);
            this.dealerScore.TabIndex = 25;
            this.dealerScore.Text = "XX";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.BackColor = System.Drawing.Color.Transparent;
            this.wins.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wins.Location = new System.Drawing.Point(502, 719);
            this.wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(43, 47);
            this.wins.TabIndex = 27;
            this.wins.Text = "0";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.BackColor = System.Drawing.Color.Transparent;
            this.losses.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.losses.Location = new System.Drawing.Point(614, 719);
            this.losses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(43, 47);
            this.losses.TabIndex = 29;
            this.losses.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(582, 719);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 47);
            this.label3.TabIndex = 28;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(698, 719);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 47);
            this.label4.TabIndex = 30;
            this.label4.Text = "Losses";
            // 
            // betUpDown
            // 
            this.betUpDown.AutoSize = true;
            this.betUpDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.betUpDown.DecimalPlaces = 2;
            this.betUpDown.Location = new System.Drawing.Point(40, 827);
            this.betUpDown.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
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
            this.betUpDown.Size = new System.Drawing.Size(186, 38);
            this.betUpDown.TabIndex = 32;
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
            this.betButton.Location = new System.Drawing.Point(264, 823);
            this.betButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(160, 52);
            this.betButton.TabIndex = 33;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // playerBalance
            // 
            this.playerBalance.AutoSize = true;
            this.playerBalance.BackColor = System.Drawing.Color.Transparent;
            this.playerBalance.Font = new System.Drawing.Font("Wide Latin", 9.857143F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerBalance.Location = new System.Drawing.Point(544, 29);
            this.playerBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerBalance.Name = "playerBalance";
            this.playerBalance.Size = new System.Drawing.Size(304, 41);
            this.playerBalance.TabIndex = 34;
            this.playerBalance.Text = "$1000.00";
            // 
            // insuranceUpDown
            // 
            this.insuranceUpDown.DecimalPlaces = 2;
            this.insuranceUpDown.Location = new System.Drawing.Point(458, 827);
            this.insuranceUpDown.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.insuranceUpDown.Name = "insuranceUpDown";
            this.insuranceUpDown.Size = new System.Drawing.Size(214, 38);
            this.insuranceUpDown.TabIndex = 35;
            this.insuranceUpDown.Visible = false;
            this.insuranceUpDown.ValueChanged += new System.EventHandler(this.insuranceUpDown_ValueChanged);
            // 
            // insuranceButton
            // 
            this.insuranceButton.Location = new System.Drawing.Point(728, 818);
            this.insuranceButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(184, 58);
            this.insuranceButton.TabIndex = 36;
            this.insuranceButton.Text = "Insurance";
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Visible = false;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(1412, 818);
            this.profileButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(184, 58);
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
            this.skipButton.Location = new System.Drawing.Point(1556, 23);
            this.skipButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(64, 62);
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
            this.muteButton.Location = new System.Drawing.Point(1480, 23);
            this.muteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(64, 62);
            this.muteButton.TabIndex = 38;
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1180, 818);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(220, 58);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.Location = new System.Drawing.Point(706, 388);
            this.addNewPlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(92, 30);
            this.addNewPlayerButton.TabIndex = 41;
            this.addNewPlayerButton.Text = "New Player";
            this.addNewPlayerButton.UseVisualStyleBackColor = true;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(706, 356);
            this.endTurnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(92, 30);
            this.endTurnButton.TabIndex = 42;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::DavesBlackjack.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.endTurnButton);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wins);
            this.Controls.Add(label420);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealerString);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBoard";
            this.Text = "BlackJack";
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
        private Label pTotalString;
        private Label dealerString;
        private Button hitButton;
        private Button stayButton;
        private Label playerScore;
        private Label dealerScore;
        private Label wins;
        private Label losses;
        private Label label3;
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
        private Button endTurnButton;
    }
}

