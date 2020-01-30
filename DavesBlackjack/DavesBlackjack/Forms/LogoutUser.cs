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
    public partial class LogoutUser : Form
    {
        public LogoutUser()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void LogoutUser_Load(object sender, EventArgs e)
        {

        }
    }
}
