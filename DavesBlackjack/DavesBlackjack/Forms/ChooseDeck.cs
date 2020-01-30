using System;
using DavesBlackjack.Properties;
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
        private Bitmap selectedDeck;
        public Bitmap cardBack { get { return selectedDeck; } }
        public ChooseDeck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.red_back;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.yellow_back;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.green_back;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.blue_back;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.purple_back;
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedDeck = Resources.gray_back;
            Close();
        }

        private void ChooseDeck_Load(object sender, EventArgs e)
        {

        }
    }
}
