﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DavesBlackjack.Classes;

namespace DavesBlackjack
{
    public partial class ProfileInfo : Form
    {
        readonly Player player;
        readonly User currentUser;
        public ProfileInfo(Player p, User u)
        {
            player = p;
            currentUser = u;
            InitializeComponent();
            userMoneyLabel.Text = player.PlayerMoney.ToString();
            
        }



        //This is not needed but could be easier for some users
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void depositMoneyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddMoneyText.Text, out int money))
            {
                if (money < 0)
                    DepositErrorLabel.Visible = true;
                else
                {
                    player.PlayerMoney += money;
                    DepositErrorLabel.Visible = false;
                    userMoneyLabel.Text = player.PlayerMoney.ToString();
                }
            }
            else
                DepositErrorLabel.Visible = true;
            AddMoneyText.Text = "";
        }

        private void WithdrawMoneyButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(WithdrawText.Text, out int money))
            {
                if (money < 0 || money > player.PlayerMoney)
                    WithdrawErrorLabel.Visible = true;
                else
                {
                    player.PlayerMoney -= money;
                    WithdrawErrorLabel.Visible = false;
                    userMoneyLabel.Text = player.PlayerMoney.ToString();
                }
            }
            else
                WithdrawErrorLabel.Visible = true;
            WithdrawText.Text = "";
        }

        private void ProfileInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentInfo NewInfo = new PaymentInfo(currentUser.username);
            Hide();
            NewInfo.ShowDialog();
            Show();
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            lblUsername.Text = currentUser.username;
            lblEmail.Text = currentUser.email;
            lblGamesWon.Text = player.wins.ToString();
        }
    }
}
