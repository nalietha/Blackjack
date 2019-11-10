using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavesBlackjack
{
    public partial class ProfileInfo : Form
    {
        public ProfileInfo()
        {
            InitializeComponent();
        }



        //This is not needed but could be easier for some users
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
