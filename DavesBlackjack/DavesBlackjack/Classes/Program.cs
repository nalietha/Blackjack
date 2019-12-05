using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavesBlackjack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>C:\Users\acema\Source\Repos\Blackjack2\DavesBlackjack\DavesBlackjack\Classes\Program.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TitleForm());
        }
    }
}
