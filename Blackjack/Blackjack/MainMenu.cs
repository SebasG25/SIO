using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            frmOnePlayerMenu onePlayerMenu = new frmOnePlayerMenu();
            onePlayerMenu.Show();
            this.Hide();
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            TwoPlayersMenu twoPlayersMenu = new TwoPlayersMenu();
            twoPlayersMenu.Show();
            this.Hide();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
