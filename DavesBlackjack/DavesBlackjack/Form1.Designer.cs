using System.Collections.Generic;
using System.Windows.Forms;

namespace DavesBlackjack
{
    partial class Form1
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
            this.label420 = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(34, 55);
            this.p1.Margin = new System.Windows.Forms.Padding(2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(149, 189);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(56, 55);
            this.p2.Margin = new System.Windows.Forms.Padding(2);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(149, 189);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 2;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(75, 55);
            this.p3.Margin = new System.Windows.Forms.Padding(2);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(149, 189);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 3;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(93, 55);
            this.p4.Margin = new System.Windows.Forms.Padding(2);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(149, 189);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 4;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(112, 55);
            this.p5.Margin = new System.Windows.Forms.Padding(2);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(149, 189);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 5;
            this.p5.TabStop = false;
            this.p5.Visible = false;
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(130, 55);
            this.p6.Margin = new System.Windows.Forms.Padding(2);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(149, 189);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 6;
            this.p6.TabStop = false;
            this.p6.Visible = false;
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(150, 55);
            this.p7.Margin = new System.Windows.Forms.Padding(2);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(149, 189);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p7.TabIndex = 7;
            this.p7.TabStop = false;
            this.p7.Visible = false;
            // 
            // p8
            // 
            this.p8.Location = new System.Drawing.Point(168, 55);
            this.p8.Margin = new System.Windows.Forms.Padding(2);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(149, 189);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p8.TabIndex = 8;
            this.p8.TabStop = false;
            this.p8.Visible = false;
            // 
            // d8
            // 
            this.d8.Location = new System.Drawing.Point(470, 55);
            this.d8.Margin = new System.Windows.Forms.Padding(2);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(149, 189);
            this.d8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d8.TabIndex = 16;
            this.d8.TabStop = false;
            this.d8.Visible = false;
            // 
            // d7
            // 
            this.d7.Location = new System.Drawing.Point(451, 55);
            this.d7.Margin = new System.Windows.Forms.Padding(2);
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(149, 189);
            this.d7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d7.TabIndex = 15;
            this.d7.TabStop = false;
            this.d7.Visible = false;
            // 
            // d6
            // 
            this.d6.Location = new System.Drawing.Point(432, 55);
            this.d6.Margin = new System.Windows.Forms.Padding(2);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(149, 189);
            this.d6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d6.TabIndex = 14;
            this.d6.TabStop = false;
            this.d6.Visible = false;
            // 
            // d5
            // 
            this.d5.Location = new System.Drawing.Point(413, 55);
            this.d5.Margin = new System.Windows.Forms.Padding(2);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(149, 189);
            this.d5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d5.TabIndex = 13;
            this.d5.TabStop = false;
            this.d5.Visible = false;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(394, 55);
            this.d4.Margin = new System.Windows.Forms.Padding(2);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(149, 189);
            this.d4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d4.TabIndex = 12;
            this.d4.TabStop = false;
            this.d4.Visible = false;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(376, 55);
            this.d3.Margin = new System.Windows.Forms.Padding(2);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(149, 189);
            this.d3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d3.TabIndex = 11;
            this.d3.TabStop = false;
            this.d3.Visible = false;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(357, 55);
            this.d2.Margin = new System.Windows.Forms.Padding(2);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(149, 189);
            this.d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d2.TabIndex = 10;
            this.d2.TabStop = false;
            this.d2.Visible = false;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(338, 55);
            this.d1.Margin = new System.Windows.Forms.Padding(2);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(149, 189);
            this.d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d1.TabIndex = 9;
            this.d1.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(32, 33);
            this.playerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(67, 21);
            this.playerName.TabIndex = 17;
            this.playerName.Text = "Player";
            // 
            // dealerName
            // 
            this.dealerName.AutoSize = true;
            this.dealerName.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerName.Location = new System.Drawing.Point(334, 32);
            this.dealerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerName.Name = "dealerName";
            this.dealerName.Size = new System.Drawing.Size(68, 21);
            this.dealerName.TabIndex = 18;
            this.dealerName.Text = "Dealer";
            // 
            // pTotalString
            // 
            this.pTotalString.AccessibleDescription = "Total: __(score)";
            this.pTotalString.AutoSize = true;
            this.pTotalString.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTotalString.Location = new System.Drawing.Point(33, 246);
            this.pTotalString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pTotalString.Name = "pTotalString";
            this.pTotalString.Size = new System.Drawing.Size(44, 13);
            this.pTotalString.TabIndex = 19;
            this.pTotalString.Text = "Total: ";
            // 
            // dealerString
            // 
            this.dealerString.AccessibleDescription = "Total: __(score)";
            this.dealerString.AutoSize = true;
            this.dealerString.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerString.Location = new System.Drawing.Point(335, 246);
            this.dealerString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerString.Name = "dealerString";
            this.dealerString.Size = new System.Drawing.Size(44, 13);
            this.dealerString.TabIndex = 20;
            this.dealerString.Text = "Total: ";
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(30, 283);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(106, 58);
            this.hitButton.TabIndex = 21;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayButton.Location = new System.Drawing.Point(30, 345);
            this.stayButton.Margin = new System.Windows.Forms.Padding(2);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(106, 65);
            this.stayButton.TabIndex = 22;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = true;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(70, 246);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(21, 13);
            this.playerScore.TabIndex = 24;
            this.playerScore.Text = "XX";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Location = new System.Drawing.Point(373, 246);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(21, 13);
            this.dealerScore.TabIndex = 25;
            this.dealerScore.Text = "XX";
            // 
            // label420
            // 
            this.label420.AutoSize = true;
            this.label420.Location = new System.Drawing.Point(335, 283);
            this.label420.Name = "label420";
            this.label420.Size = new System.Drawing.Size(31, 13);
            this.label420.TabIndex = 26;
            this.label420.Text = "Wins";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Location = new System.Drawing.Point(364, 283);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(21, 13);
            this.wins.TabIndex = 27;
            this.wins.Text = "XX";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.Location = new System.Drawing.Point(386, 283);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(21, 13);
            this.losses.TabIndex = 29;
            this.losses.Text = "XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Losses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.label420);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BlackJack";
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
        private Label label420;
        private Label wins;
        private Label losses;
        private Label label3;
        private Label label4;
    }
}

