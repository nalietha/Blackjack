using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavesBlackjack.Forms
{
    public partial class ChooseDeck : Form
    {
        private string deckString = "";
        public string cardBack { get { return deckString; } }
        public ChooseDeck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deckString = "red_back";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deckString = "yellow_back";
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deckString = "green_back";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deckString = "blue_back";
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deckString = "purple_back";
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deckString = "gray_back";
            Close();
        }
    }
}
